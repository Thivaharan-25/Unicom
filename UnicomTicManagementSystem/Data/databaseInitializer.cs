using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicManagementSystem.Data
{
    public static class DatabaseInitializer
    {
        public static void CreateTable()
        {
            try
            {
                using (var conn = DbConfig.GetConnection())
                {
                    

                    string tableQueries = @"
                CREATE TABLE IF NOT EXISTS Users (
                    UsersId INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserCode TEXT,
                    UserName TEXT NOT NULL,
                    UsersPassword TEXT NOT NULL,
                    UsersAddress TEXT NOT NULL,
                    UsersGender TEXT NOT NULL,
                    UsersRole TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Courses (
                    CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                    CName TEXT NOT NULL,
                    CPassword TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Subject (
                    SubjectId INTEGER PRIMARY KEY AUTOINCREMENT,
                    SubjectName TEXT NOT NULL,
                    CourseId INTEGER,
                    FOREIGN KEY (CourseId) REFERENCES Courses(CourseID)
                );

                CREATE TABLE IF NOT EXISTS Students (
                    StudentId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Password TEXT NOT NULL,
                    Address TEXT,
                    Gender TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Lecturer (
                    LecturerId INTEGER PRIMARY KEY AUTOINCREMENT,
                    LName TEXT NOT NULL,
                    LPassword TEXT NOT NULL,
                    LGender TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Staff (
                    StaffId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Password TEXT NOT NULL,
                    Address TEXT,
                    Gender TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Admin (
                    AdminId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Password TEXT NOT NULL,
                    Address TEXT,
                    Gender TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS HALLS (HallNo INTEGER PRIMARY KEY,
                    HName TEXT NOT NULL 
                );
            ";

                    SQLiteCommand cmd = new SQLiteCommand(tableQueries, conn);
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Table creation failed: " + ex.Message);
                throw;
            }
        }
    }
}