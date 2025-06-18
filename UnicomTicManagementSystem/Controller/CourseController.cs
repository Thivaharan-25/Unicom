using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using UnicomTicManagementSystem.Data;
using UnicomTicManagementSystem.Method;
using UnicomTicManagementSystem.View;

namespace UnicomTicManagementSystem.Controller
{
    internal class CourseController
    {
        public List<CourseName> GetAllCourse()
        {
            var courses = new List<CourseName>();

            using (var conn = DbConfig.GetConnection())
            {
            

                // Join query to fetch courses along with their subject names
                string query = @"
                            SELECT c.CourseID, c.CName, s.SubjectName 
                            FROM Courses c
                            LEFT JOIN Subject s ON c.CourseID = s.CourseId";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        courses.Add(new CourseName
                        {
                            Id = reader.GetInt32(0),
                            Course = reader.GetString(1),
                            Subject = reader.IsDBNull(2) ? null : reader.GetString(2)
                        });
                    }
                }
            }

            return courses;
        }



        public bool AddCourse(CourseName course)
        {
            try
            {
                using (var conn = DbConfig.GetConnection())
                {
                    int courseId = -1;

                    // 1. Check if course already exists
                    string checkCourseQuery = "SELECT CourseID FROM Courses WHERE CName = @courseName";
                    using (var checkCmd = new SQLiteCommand(checkCourseQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@courseName", course.Course);
                        var result = checkCmd.ExecuteScalar();
                        if (result != null)
                        {
                            // Course exists, get the ID
                            courseId = Convert.ToInt32(result);
                        }
                    }

                    if (courseId == -1)
                    {
                        // 2. Course doesn't exist, insert it
                        string insertCourseQuery = "INSERT INTO Courses (CName) VALUES (@courseName)";
                        using (var insertCmd = new SQLiteCommand(insertCourseQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@courseName", course.Course);
                            insertCmd.ExecuteNonQuery();
                        }

                        // 3. Get the new Course ID
                        string getIdQuery = "SELECT last_insert_rowid()";
                        using (var idCmd = new SQLiteCommand(getIdQuery, conn))
                        {
                            courseId = Convert.ToInt32(idCmd.ExecuteScalar());
                        }
                    }

                    // 4. Insert the subject (only if it's not already added for that course)
                    string checkSubjectQuery = "SELECT COUNT(*) FROM Subject WHERE SubjectName = @subjectName AND CourseId = @courseId";
                    using (var checkSubjectCmd = new SQLiteCommand(checkSubjectQuery, conn))
                    {
                        checkSubjectCmd.Parameters.AddWithValue("@subjectName", course.Subject);
                        checkSubjectCmd.Parameters.AddWithValue("@courseId", courseId);
                        long count = (long)checkSubjectCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("This subject is already added to the course.");
                            return false;
                        }
                    }

                    string insertSubjectQuery = "INSERT INTO Subject (SubjectName, CourseId) VALUES (@subjectName, @courseId)";
                    using (var subjectCmd = new SQLiteCommand(insertSubjectQuery, conn))
                    {
                        subjectCmd.Parameters.AddWithValue("@subjectName", course.Subject);
                        subjectCmd.Parameters.AddWithValue("@courseId", courseId);
                        subjectCmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding course and subject: " + ex.Message);
                return false;
            }
        }





        public bool AddSubjectToCourse(int courseId, string subjectName , string courseName)
        {
            try
            {
               
                using (var conn = DbConfig.GetConnection())
                {
                string query = "INSERT INTO Subject (SubjectName, CourseId) VALUES (@subjectName, @courseId)";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@subjectName", subjectName);
                        cmd.Parameters.AddWithValue("@courseId", courseId);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;

            }
            catch (Exception ex)
            {
                // Log exception if needed
                return false;
            }
        }
        //public List<CourseName> GetAllCourse()
        //{
        //    var courses = new List<CourseName>();
        //    using (var conn = DbConfig.GetConnection())
        //    {
        //        conn.Open();
        //        var cmd = conn.CreateCommand();
        //        cmd.CommandText = "SELECT CourseID, CName FROM Courses";
        //        using (var reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                courses.Add(new CourseName
        //                {
        //                    id = reader.GetInt32(0),
        //                    course = reader.GetString(1),
        //                    // subject list is not stored in Courses table
        //                    subject = null
        //                });
        //            }
        //        }
        //    }
        //    return courses;
        //}
        public List<string> GetSubjectsByCourse(string courseName)
        {
            var subjects = new List<string>();
            using (var conn = DbConfig.GetConnection())
            {
               

                // First get course ID by name
                string getCourseIdQuery = "SELECT CourseID FROM Courses WHERE CName = @courseName";
                int courseId = -1;

                using (var cmd = new SQLiteCommand(getCourseIdQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@courseName", courseName);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        courseId = Convert.ToInt32(result);
                    }
                    else
                    {
                        // course not found, return empty list
                        return subjects;
                    }
                }

                // Now get subjects by CourseId
                string getSubjectsQuery = "SELECT SubjectName FROM Subject WHERE CourseId = @courseId";
                using (var cmd = new SQLiteCommand(getSubjectsQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@courseId", courseId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            subjects.Add(reader.GetString(0));
                        }
                    }
                }
            }
            return subjects.Distinct().ToList();
        }


    }
}
