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
                        mark.Add(new Mark
                        {

                            Id = reader.GetInt32(0),
                            StudentCode = reader.GetString(1),
                            Name = reader.GetString(2),
                            Subject= reader.GetString(3),
                            

                        });
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


    }
}
