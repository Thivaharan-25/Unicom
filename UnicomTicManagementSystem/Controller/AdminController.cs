using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicManagementSystem.Data;
using UnicomTicManagementSystem.Method;
using UnicomTicManagementSystem.View;

namespace UnicomTicManagementSystem.Controller
{
    internal class adminController
    {
        //public List<Admin> getalladmin()
        public void insertadmin (Admin admin)
        { 
         //List<Admin> admin = new List<Admin>();
            using (var conn = DbConfig.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = /*new SQLiteCommand*/ "INSERT INTO Students (Name,Password,Address,Gender  VALUES (@name ,@password,@address,@gender) ";
                cmd.Parameters.AddWithValue("@name", admin.Name);
                cmd.Parameters.AddWithValue("@password", admin.Password);
                cmd.Parameters.AddWithValue("@gender", admin.Gender);
                cmd.ExecuteNonQuery();


            }
            //return admin;
        }
        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            using (var conn = DbConfig.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Students ";  var conn1 = conn;


                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {

                            StudentId = reader.GetInt32(0),   
                            Name = reader.GetString(1),
                            Address = reader.GetString(2),
                            Password = reader.GetString(3)

                        });
                    }
                }
            }
            return students;
        }
        public void Insertsaff(Staff staff)
        {

            using (var conn = DbConfig.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Staff (Name,Password,Address,Gender  VALUES (@name ,@password,@address,@gender) ";
                cmd.Parameters.AddWithValue("@name", staff.Name);
                cmd.Parameters.AddWithValue("@password", staff.Password);
                cmd.Parameters.AddWithValue("@address", staff.Address);
                cmd.Parameters.AddWithValue("@gender", staff.Gender);
                cmd.ExecuteNonQuery();
            }
        }
        public List<Staff> GetAllStaff()
        {
            List<Staff> staff = new List<Staff>();
            using (var conn = DbConfig.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Staff";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        staff.Add(new Staff
                        {
                            StaffId = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Address = reader.GetString(2),
                            Password = reader.GetString(3),
                            Gender = reader.GetString(4)

                        });
                    }
                }
            }
            return staff;
        }
    }

}
