using Microsoft.VisualBasic.ApplicationServices;
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

        public List<Student> Getstudent()
        {
            List<Student> users = new List<Student>();
            using (var conn = DbConfig.GetConnection())
            {

                var cmd = new SQLiteCommand(@"SELECT * FROM Student", conn);
                //cmd.CommandText = "SELECT * FROM Users"; var conn1 = conn;


                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new Student
                        {

                            Id = reader.GetInt32(0),
                            StudentCode = reader.GetString(1),
                            Name = reader.GetString(2),
                            Password = reader.GetString(3),

                        
                          

                        });
                    }
                }
            }
            return users;
        }

        public bool Login(Credentials credentials)
        {
            try
            {
                var user = new Users();

                using (var conn = DbConfig.GetConnection())
                {
                    string query = "SELECT UserCode, UsersPassword, UsersRole FROM Users WHERE UserCode = @UserCode";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserCode", credentials.userName);

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user.username = reader["UserCode"].ToString();
                                user.password = reader["UsersPassword"].ToString();
                                user.Role = reader["UsersRole"].ToString();

                                if (user.password.Trim() == credentials.password.Trim())
                                {
                                    Session.LoggedInUser = user;
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message);
            }

            return false;
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
                    using (var cmd = new SQLiteCommand("INSERT INTO Students (StudentId, Name, Address, Gender , Password) VALUES (@UserId, @Name, @Address, @Gender , @password)", conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", id);
                        cmd.Parameters.AddWithValue("@Name", user.username);
                        cmd.Parameters.AddWithValue("@Address", user.address);
                        cmd.Parameters.AddWithValue("@Gender", user.Gender);
                        cmd.Parameters.AddWithValue("@password", user.password);
                        cmd.ExecuteNonQuery();
                    }
                }
                else if (user.Role.ToLower() == "lecturer")
                {
                    using (var cmd = new SQLiteCommand("INSERT INTO Lecturers (LecturerId, LName, LAddress, LGender ,LPassword) VALUES (@UserId, @Name, @Address, @Gender ,@password)", conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", id);
                        cmd.Parameters.AddWithValue("@Name", user.username);
                        cmd.Parameters.AddWithValue("@Address", user.address);
                        cmd.Parameters.AddWithValue("@Gender", user.Gender);
                        cmd.Parameters.AddWithValue("@password", user.password);
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

                if (user.Role.ToLower() == "student")
                {
                    using (var cmd = new SQLiteCommand("UPDATE Students SET Name=@Name,Address=@Address,Gender=@Gender,Password=@password WHERE UsersId = @UserId", conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId",user.Id);
                        cmd.Parameters.AddWithValue("@Name", user.username);
                        cmd.Parameters.AddWithValue("@Address", user.address);
                        cmd.Parameters.AddWithValue("@Gender", user.Gender);
                        cmd.Parameters.AddWithValue("@password", user.password);
                        cmd.ExecuteNonQuery();
                    }
                }
                else if (user.Role.ToLower() == "lecturer")
                {
                    using (var cmd = new SQLiteCommand("UPDATE Lecturers SET LName=@Name, LAddress=@Address, LGender=@Gender ,LPassword=@password WHERE UsersId = @UserId", conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId",user.Id);
                        cmd.Parameters.AddWithValue("@Name", user.username);
                        cmd.Parameters.AddWithValue("@Address", user.address);
                        cmd.Parameters.AddWithValue("@Gender", user.Gender);
                        cmd.Parameters.AddWithValue("@password", user.password);
                        cmd.ExecuteNonQuery();
                    }
                }

            }
            return user;
        }

        public void DeleteUser(int usersId)
        {
            using (var conn = DbConfig.GetConnection())
            {
              

                // First, get the role of the user
                string role = "";
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT UsersRole FROM Users WHERE UsersId = @id";
                    cmd.Parameters.AddWithValue("@id", usersId);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        role = result.ToString().ToLower();
                    }
                }

                // Delete from respective role-specific table
                if (role == "student")
                {
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "DELETE FROM Students WHERE UsersId = @id";
                        cmd.Parameters.AddWithValue("@id", usersId);
                        cmd.ExecuteNonQuery();
                    }
                }
                else if (role == "staff" || role == "lecturer")
                {
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "DELETE FROM Lecturers WHERE UsersId = @id";
                        cmd.Parameters.AddWithValue("@id", usersId);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Finally, delete from Users table
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Users WHERE UsersId = @id";
                    cmd.Parameters.AddWithValue("@id", usersId);
                    cmd.ExecuteNonQuery();
                }
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

