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
using static UnicomTicManagementSystem.Method.Users;

namespace UnicomTicManagementSystem.Controller
{
    internal class adminController
    {
        //public List<Admin> getalladmin()
        //public void InsertAdmin(Admin admin)
        //{
        //    using (var conn = DbConfig.GetConnection())
        //    {
        //        var cmd = conn.CreateCommand();
        //        cmd.CommandText = "INSERT INTO Users (UserName, UserPassword, UserAddress, UserGender) VALUES (@name, @password, @address, @gender)";
        //        cmd.Parameters.AddWithValue("@name", admin.Name);
        //        cmd.Parameters.AddWithValue("@password", admin.Password);
        //        cmd.Parameters.AddWithValue("@gender", admin.Gender);

        //        cmd.ExecuteNonQuery();
        //    }
        //}
        //return admin;

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            using (var conn = DbConfig.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Students "; var conn1 = conn;


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
        //public void Insertsaff(Staff staff)
        //{

        //    using (var conn = DbConfig.GetConnection())
        //    {
        //        var cmd = conn.CreateCommand();
        //        cmd.CommandText = "INSERT INTO Staff (Name, Password, Address, Gender) VALUES (@name, @password, @address, @gender)";
        //        cmd.Parameters.AddWithValue("@name", staff.Name);
        //        cmd.Parameters.AddWithValue("@password", staff.Password);
        //        cmd.Parameters.AddWithValue("@address", staff.Address);
        //        cmd.Parameters.AddWithValue("@gender", staff.Gender);
        //        cmd.ExecuteNonQuery();
        //    }
        //}
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
        public bool Login(Credentials credentials)
        {
            try
            {
                var user = new Users();
                using (var conn = DbConfig.GetConnection())
                {


                    string query = "SELECT Username, Password  FROM Users WHERE Username = @Username";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@Username", credentials.userName);


                        SQLiteDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            user.username = reader["Username"].ToString();
                            user.password = reader["Password"].ToString();
                        }
                    }
                    if (user.password == credentials.password)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                };
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public Users AddUser(Users user)
        {
            using (var conn = DbConfig.GetConnection())
            {
                conn.Open();
                string query = "Insert into Users(Name , UserId ,Password ,Role, Gender) values(@Name , @UserId , @Password , @Role , @Gender)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", user.username);
                    cmd.Parameters.AddWithValue("@UserId", user.Id);
                    cmd.Parameters.AddWithValue("@Password", user.password);
                    cmd.Parameters.AddWithValue("@Role", user.Role);
                    cmd.Parameters.AddWithValue("@Gender", user.Gender);
                    cmd.ExecuteNonQuery();
                }


            }
            return user;
        } 
    }
}
