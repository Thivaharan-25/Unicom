using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using UnicomTicManagementSystem.Data;
using UnicomTicManagementSystem.Method;
using UnicomTicManagementSystem.View;

namespace UnicomTicManagementSystem.Controller
{
    internal class TimeTableController
    {
        public List<TimeTable> GetTimeTable()
        {
            var timetable = new List<TimeTable>();

            using (var conn = DbConfig.GetConnection())
            {


                // Join query to fetch courses along with their subject names
                string query = "SELECT * FROM TimeTable";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        timetable.Add(new TimeTable
                        {
                            Id = reader.GetInt32(0),
                            DateOfWeek = reader.IsDBNull(1) ? null : reader.GetString(1),
                            TimeSlot = reader.IsDBNull(2) ? null : reader.GetString(2),
                            Course = reader.IsDBNull(3) ? null : reader.GetString(3),
                            Subject = reader.IsDBNull(4) ? null : reader.GetString(4),
                            Lecturer = reader.IsDBNull(5) ? null : reader.GetString(5),
                            Hall = reader.IsDBNull(6) ? null : reader.GetString(6),
                        });

                    }
                }
            }

            return timetable;
        }
        public List<string> GetAllSubjectNames()
        {
            List<string> subjectNames = new List<string>();

            using (var conn = DbConfig.GetConnection())
            {
                string query = "SELECT SubjectName FROM Subject";
                using (var cmd = new SQLiteCommand(query, conn))


                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        subjectNames.Add(reader["SubjectName"].ToString());
                    }
                }
            }

            return subjectNames;
        }

        public bool UpdateTime(TimeTable time)
        {
            try
            {
                using (var conn = DbConfig.GetConnection())
                {
                    string quary = @"UPDATE TimeTable 
                                    SET DayOfWeek = @date, TimeSlot = @time, CourseID = @course,
                                    SubjectId = @subject, LecturerId = @lecturer, HallNo = @hall
                                    WHERE TimetableID = @id";

                    using (SQLiteCommand cmd = new SQLiteCommand(quary, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", time.Id);
                        cmd.Parameters.AddWithValue("@date", time.DateOfWeek);
                        cmd.Parameters.AddWithValue("@time", time.TimeSlot);
                        cmd.Parameters.AddWithValue("@course", time.Course);
                        cmd.Parameters.AddWithValue("@subject", time.Subject);
                        cmd.Parameters.AddWithValue("@lecturer", time.Lecturer);
                        cmd.Parameters.AddWithValue("@hall", time.Hall);
                        cmd.ExecuteNonQuery();
                    }
                    using (var conn1 = DbConfig.GetConnection())
                    {
                        string query = @"UPDATE Hall 
                                       SET HName = @name, RoomType = @type
                                       WHERE HallNo = @id";
                        using (SQLiteCommand cmd = new SQLiteCommand(query, conn1))
                        {
                            cmd.Parameters.AddWithValue("@id", time.HallNo);
                            cmd.Parameters.AddWithValue("@name", time.Hall);
                            cmd.Parameters.AddWithValue("@type", time.RoomType);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return true;
                }
            }
            catch
            {
                return false;
            }
        
            
        }

        public bool AddTime(TimeTable time)
        {
            try
            {
                using (var conn = DbConfig.GetConnection())
                {
                    string query = "INSERT INTO TimeTable(TimetableID,DayOfWeek,TimeSlot,CourseID,SubjectId,LecturerId,HallNo) " +
                                   "VALUES (@id, @date, @time, @course, @subject, @lecturer,@hall)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", time.Id);
                        cmd.Parameters.AddWithValue("@date", time.DateOfWeek);
                        cmd.Parameters.AddWithValue("@time", time.TimeSlot);
                        cmd.Parameters.AddWithValue("@course", time.Course);
                        cmd.Parameters.AddWithValue("@subject", time.Subject);
                        cmd.Parameters.AddWithValue("@lecturer", time.Lecturer);
                        cmd.Parameters.AddWithValue("@hall", time.Hall);
                        cmd.ExecuteNonQuery();
                    }
                    using (var conn1 = DbConfig.GetConnection())
                    {
                        string quary = "INSERT INTO Hall (Hallno,HName,RoomType)" + "VALUES (@id, @name,@type)";
                        using (SQLiteCommand cmd = new SQLiteCommand (quary,conn1))
                        {
                            cmd.Parameters.AddWithValue("@id", time.HallNo);
                            cmd.Parameters.AddWithValue("@name", time.Hall);
                            cmd.Parameters.AddWithValue("@type",time.RoomType);
                            cmd.ExecuteNonQuery ();
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<string> GetAllCourseNames()
        {
            List<string> CourseNames = new List<string>();

            using (var conn = DbConfig.GetConnection())
            {
                string query = "SELECT CName FROM Courses";
                using (var cmd = new SQLiteCommand(query, conn))


                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CourseNames.Add(reader["CName"].ToString());
                    }
                }
            }

            return CourseNames;
        }
    }
}
