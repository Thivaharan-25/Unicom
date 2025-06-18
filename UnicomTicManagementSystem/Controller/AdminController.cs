using System;
using System.Collections;
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


        public List<Users> GetAllUsers()
        {
            List<Users> users = new List<Users>();
            using (var conn = DbConfig.GetConnection())
            {

                var cmd = new SQLiteCommand(@"SELECT * FROM Users", conn);
                //cmd.CommandText = "SELECT * FROM Users"; var conn1 = conn;


                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new Users
                        {

                            Id = reader.GetInt32(0),
                            UserCode = reader.GetString(1),
                            username = reader.GetString(2),
                            address = reader.GetString(4),
                            password = reader.GetString(3),
                            Gender = reader.GetString(5),
                            Role = reader.GetString(6)

                        });
                    }
                }
            }
            return users;
        }

        //public List<Method.Course> GetAllStudents()
        //{
        //    List<Method.Course> students = new List<Method.Course>();
        //    using (var conn = DbConfig.GetConnection())
        //    {
        //        var cmd = conn.CreateCommand();
        //        cmd.CommandText = "SELECT * FROM Students "; var conn1 = conn;


        //        using (var reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                students.Add(new Method.Course
        //                {

        //                    StudentId = reader.GetInt32(0),
        //                    Name = reader.GetString(1),
        //                    Address = reader.GetString(2),
        //                    Password = reader.GetString(3)

        //                });
        //            }
        //        }
        //    }
        //    return students;
        //}
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
        //public List<Staff> GetAllStaff()
        //{
        //    List<Staff> staff = new List<Staff>();
        //    using (var conn = DbConfig.GetConnection())
        //    {
        //        var cmd = conn.CreateCommand();
        //        cmd.CommandText = "SELECT * FROM Staff";

        //        using (var reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                staff.Add(new Staff
        //                {
        //                    StaffId = reader.GetInt32(0),
        //                    Name = reader.GetString(1),
        //                    Address = reader.GetString(2),
        //                    Password = reader.GetString(3),
        //                    Gender = reader.GetString(4)

        //                });
        //            }
        //        }
        //    }
        //    return staff;
        //}
        public bool Login(Credentials credentials)
        {
            try
            {
                var user = new Users();
                using (var conn = DbConfig.GetConnection())
                {


                    string query = "SELECT UserCode, UsersPassword FROM Users WHERE UserCode = @Username";


                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@UserCode", credentials.userName);


                        SQLiteDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            user.username = reader["UserCode"].ToString();
                            user.password = reader["UsersPassword"].ToString();
                            //user.Role = reader["UsersRole"].ToString;

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
                // Step 1: Insert user (UserCode will be updated after generating it)
                string query = "INSERT INTO Users(UserName, UsersPassword, UsersRole, UsersGender, UsersAddress) " +
                               "VALUES (@Name, @Password, @Role, @Gender, @address)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", user.username);
                    cmd.Parameters.AddWithValue("@Password", user.password);
                    cmd.Parameters.AddWithValue("@Role", user.Role);
                    cmd.Parameters.AddWithValue("@Gender", user.Gender);
                    cmd.Parameters.AddWithValue("@address", user.address);
                    cmd.ExecuteNonQuery();
                }

                // Step 2: Get last inserted user ID
                long id;
                using (var cmd = new SQLiteCommand("SELECT last_insert_rowid();", conn))
                {
                    id = (long)cmd.ExecuteScalar();
                }

                // Step 3: Generate user code
                string prefix = GetPrefix(user.Role);
                string userCode = $"{prefix}{id:D3}";
                user.Id = (int)id;
                user.UserCode = userCode;

                // Step 4: Update user with generated UserCode
                using (var cmd = new SQLiteCommand("UPDATE Users SET UserCode = @UserCode WHERE UsersId = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@UserCode", userCode);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }

                // Step 5: Insert into role-specific table
                if (user.Role.ToLower() == "student")
                {
                    using (var cmd = new SQLiteCommand("INSERT INTO Students (StudentId, Name, Address, Gender) VALUES (@UserId, @Name, @Address, @Gender)", conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", id);
                        cmd.Parameters.AddWithValue("@Name", user.username);
                        cmd.Parameters.AddWithValue("@Address", user.address);
                        cmd.Parameters.AddWithValue("@Gender", user.Gender);
                        cmd.ExecuteNonQuery();
                    }
                }
                else if (user.Role.ToLower() == "lecturer")
                {
                    using (var cmd = new SQLiteCommand("INSERT INTO Lecturers (LecturerId, LName, LAddress, LGender) VALUES (@UserId, @Name, @Address, @Gender)", conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", id);
                        cmd.Parameters.AddWithValue("@Name", user.username);
                        cmd.Parameters.AddWithValue("@Address", user.address);
                        cmd.Parameters.AddWithValue("@Gender", user.Gender);
                        cmd.ExecuteNonQuery();
                    }
                }

                return user;
            }
        }


        public Users UpdateUser(Users user)
        {
            using (var conn = DbConfig.GetConnection())
            {
                
                string existingRole = null;
                using (var cmd = new SQLiteCommand("SELECT UsersRole FROM Users WHERE UsersId = @UserId", conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", user.Id);
                    existingRole = cmd.ExecuteScalar()?.ToString();
                }

               
                user.Role = existingRole;

                string query = "UPDATE Users SET UserName = @Name, " +
                      "UsersPassword = @Password, UsersRole = @Role, " +
                      "UsersGender = @Gender, UsersAddress = @address " +
                      "WHERE UsersId = @UserId";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", user.Id);
                    cmd.Parameters.AddWithValue("@Name", user.username);
                    cmd.Parameters.AddWithValue("@Password", user.password);
                    cmd.Parameters.AddWithValue("@Role", user.Role); 
                    cmd.Parameters.AddWithValue("@Gender", user.Gender);
                    cmd.Parameters.AddWithValue("@address", user.address);
                    cmd.ExecuteNonQuery();
                }
            }
            return user;
        }

        public void DeleteUser(int UsersId)
        {
            using (var conn = DbConfig.GetConnection())
            {

                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Users WHERE UsersId = @id";
                cmd.Parameters.AddWithValue("@id", UsersId);
                cmd.ExecuteNonQuery();

                //{
                //    cmd.Parameters.AddWithValue("@UserId", user.Id);
                //    cmd.Parameters.AddWithValue("@Name", user.username);
                //    cmd.Parameters.AddWithValue("@Password", user.password);
                //    cmd.Parameters.AddWithValue("@Role", user.Role);
                //    cmd.Parameters.AddWithValue("@Gender", user.Gender);
                //    cmd.Parameters.AddWithValue("@address", user.address);
                //    cmd.ExecuteNonQuery();
                //}
            }

        }
        private string GetPrefix(string role)
        {
            return role.ToLower() switch
            {
                "admin" => "AT",
                "student" => "UT",
                "staff" => "ST",
                "lecturer" => "LT",
                _ => "UN"
            };
        }
    }
    
}

