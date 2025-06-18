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

                CREATE TABLE IF NOT EXISTS Courses(
                    CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                    CName TEXT NOT NULL
                  
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

                CREATE TABLE IF NOT EXISTS Lecturers (
                    LecturerId INTEGER PRIMARY KEY AUTOINCREMENT,
                    LName TEXT NOT NULL,
                    LPassword TEXT NOT NULL,
                    LGender TEXT NOT NULL,
                    LAddress TEXT NOT NULL,
                    CourseId INTEGER,
                    FOREIGN KEY (CourseId) REFERENCES Courses(CourseID)
                );

                CREATE TABLE IF NOT EXISTS TimeTable (
                    TimetableID INTEGER PRIMARY KEY AUTOINCREMENT,
                    DayOfWeek VARCHAR(10), 
                    TimeSlot VARCHAR(20), 
                    CourseID INTEGER,
                    SubjectId INTEGER,
                    LecturerId INTEGER,
                    HallNo INTEGER,
                    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID),
                    FOREIGN KEY (SubjectId) REFERENCES Subject(SubjectId),
                    FOREIGN KEY (LecturerId) REFERENCES Lecturer(LecturerId),
                    FOREIGN KEY (HallNo) REFERENCES Halls(HallNo)
                );

                

                CREATE TABLE IF NOT EXISTS Admin (
                    AdminId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Password TEXT NOT NULL,
                    Address TEXT,
                    Gender TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Halls (HallNo INTEGER PRIMARY KEY,
                    RoomType TEXT NOT NULL,
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