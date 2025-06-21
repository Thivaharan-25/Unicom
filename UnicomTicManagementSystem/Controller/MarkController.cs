using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicManagementSystem.Data;
using UnicomTicManagementSystem.Method;

namespace UnicomTicManagementSystem.Controller
{
    internal class MarkController
    {
        public List<Mark> GetAllMark()
        {
            List<Mark> mark = new List<Mark>();
            using (var conn = DbConfig.GetConnection())
            {

                var cmd = new SQLiteCommand(@"SELECT * FROM Mark", conn);
                //cmd.CommandText = "SELECT * FROM Users"; var conn1 = conn;


                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            int id = reader.GetInt32(0);
                            string userCode = reader.IsDBNull(6) ? null : reader.GetString(6);
                            int score = reader.GetInt32(4); // may throw if column is NULL or not INT
                            string subject = reader.IsDBNull(5) ? null : reader.GetString(5);

                            mark.Add(new Mark
                            {
                                Id = id,
                                StudentCode = userCode,
                                Score = score,
                                Subject = subject
                            });
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Data parsing error: " + ex.Message);
                        }
                    }

                }
            }
            return mark;
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

        public void DeleteMark(int mark)
        {
            using (var conn = DbConfig.GetConnection())
            {

                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Mark WHERE MarkID = @id";
                cmd.Parameters.AddWithValue("@id", mark);
                cmd.ExecuteNonQuery();

            }
        }

        public bool UpdateMark(Mark mark)
        {
            try
            {
                using (var conn = DbConfig.GetConnection())
                {
                    string quary = @"UPDATE Mark 
                             SET UserCode = @code,Score = @mark,SubjectName=@subject
                             WHERE MarkID=@id";

                    using (SQLiteCommand cmd = new SQLiteCommand(quary, conn))
                    {
          
                        cmd.Parameters.AddWithValue("@mark", mark.Score);

                        cmd.Parameters.AddWithValue("@subject", mark.Subject);

                        cmd.Parameters.AddWithValue("@code", mark.StudentCode);

                        cmd.Parameters.AddWithValue("@id", mark.Id);

                        cmd.ExecuteNonQuery();
                    }

                    //using (var conn1 = DbConfig.GetConnection())
                    //{
                    //    string query = @"UPDATE Halls 
                    //             SET HName = @name, RoomType = @type
                    //             WHERE HallNo = @id";

                    //    using (SQLiteCommand cmd = new SQLiteCommand(query, conn1))
                    //    {
                    //        cmd.Parameters.AddWithValue("@id", time.HallNo); // ✅ ADD THIS
                    //        cmd.Parameters.AddWithValue("@name", time.Hall);
                    //        cmd.Parameters.AddWithValue("@type", time.RoomType);
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


       

        public bool AddMark(Mark mark)
        {
            try
            {
                using (var conn = DbConfig.GetConnection())
                {
                    string query = "INSERT INTO Mark (Score,SubjectName,UserCode) " +
                                   "VALUES (@mark,@name,@code)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        //cmd.Parameters.AddWithValue("@id", mark.Id);    
                        cmd.Parameters.AddWithValue("@mark", mark.Score);
                        cmd.Parameters.AddWithValue("@code", mark.StudentCode);

                        cmd.Parameters.AddWithValue("@name", mark.Subject);

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
    }
}