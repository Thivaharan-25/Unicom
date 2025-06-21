using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UnicomTicManagementSystem.Data;
using UnicomTicManagementSystem.Method;

namespace UnicomTicManagementSystem.Controller
{
    internal class ExamController
    {
        public List<ExamN> GetAllExam()
        {
            var exam = new List<ExamN>();

            using (var conn = DbConfig.GetConnection())
            {
                string quary = "SELECT * FROM Exam";
                using (var cmd = new SQLiteCommand(quary, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        exam.Add(new ExamN
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(6),
                            Subject = reader.GetString(4),
                            Hall = reader.GetString(5),
                            TimeSlot = reader.GetString(1),
                            Date = reader.GetString(2),
                        });
                    }
                }
            }
            return exam;

        }
        public bool UpdateExam(ExamN exam)
        {
            try
            {
                using (var conn = DbConfig.GetConnection())
                {
                    string quary = @"UPDATE Exam 
                             SET DayOfWeek = @date, TimeSlot = @time, 
                                 SubjectName = @subject,EHall = @hall
                             WHERE TimetableID = @id";

                    using (SQLiteCommand cmd = new SQLiteCommand(quary, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", exam.Id); // ✅ ADD THIS
                        cmd.Parameters.AddWithValue("@date", exam.Date);
                        cmd.Parameters.AddWithValue("@time", exam.TimeSlot);

                        cmd.Parameters.AddWithValue("@subject", exam.Subject);

                        cmd.Parameters.AddWithValue("@hall", exam.Hall);
                        cmd.ExecuteNonQuery();
                    }

                    //using (var conn1 = DbConfig.GetConnection())
                    //{
                    //    string query = @"UPDATE Halls 
                    //             SET HName = @name, RoomType = @type
                    //             WHERE HallNo = @id";

                    //    using (SQLiteCommand cmd = new SQLiteCommand(query, conn1))
                    //    {
                    //        cmd.Parameters.AddWithValue("@id", exam.HallNo); // ✅ ADD THIS
                    //        cmd.Parameters.AddWithValue("@name", exam.Hall);
                    //        cmd.Parameters.AddWithValue("@type", exam.RoomType);
                    //        cmd.ExecuteNonQuery();
                    //    }
                    //}

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public bool AddExam(ExamN exam)
        {
            try
            {
                using (var conn = DbConfig.GetConnection())
                {
                    string query = "INSERT INTO Exam(EId,Date,TimeSlot,SubjectName,EHall,EName) " +
                                   "VALUES (@id ,@date, @time,@subject,@hall,@name)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@date", exam.Date);
                        cmd.Parameters.AddWithValue("@time", exam.TimeSlot);
                        cmd.Parameters.AddWithValue("@name", exam.Name);
                        cmd.Parameters.AddWithValue("@subject", exam.Subject);
                        cmd.Parameters.AddWithValue("@id", exam.Id);
                        cmd.Parameters.AddWithValue("@hall", exam.Hall);
                        cmd.ExecuteNonQuery();
                    }
                    //using (var conn1 = DbConfig.GetConnection())
                    //{
                    //    string quary = "INSERT INTO Halls (HName,RoomType)" + "VALUES (@name,@type)";
                    //    using (SQLiteCommand cmd = new SQLiteCommand(quary, conn1))
                    //    {
                    //        //cmd.Parameters.AddWithValue("@id", time.HallNo);
                    //        cmd.Parameters.AddWithValue("@name", exam.Hall);
                    //        cmd.Parameters.AddWithValue("@type", exam.RoomType);
                    //        cmd.ExecuteNonQuery();
                    //    }
                    //}
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public void DeleteUser(int ExamId)
        {
            using (var conn = DbConfig.GetConnection())
            {

                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Exam WHERE EId = @id";
                cmd.Parameters.AddWithValue("@id", ExamId);
                cmd.ExecuteNonQuery();


            }
        }
    }
}
