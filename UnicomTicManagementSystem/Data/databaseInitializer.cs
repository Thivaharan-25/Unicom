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

                -- Insert default user only if table is empty
                    INSERT INTO Users (UserCode, UserName, UsersPassword, UsersAddress, UsersGender, UsersRole)
                    SELECT 'AT010776', 'Default Admin', '1234', 'Admin Address', 'Male', 'admin'
                    WHERE NOT EXISTS (SELECT 1 FROM Users
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
                    Gender TEXT NOT NULL,
                    UsersId INTEGER,
                    UserCode TEXT,
                    FOREIGN KEY (UsersId) REFERENCES Users(UsersId),
                    FOREIGN KEY (UserCode) REFERENCES Users(UserCode) 
                );

                CREATE TABLE IF NOT EXISTS Lecturers (
                    LecturerId INTEGER PRIMARY KEY AUTOINCREMENT,
                    LName TEXT NOT NULL,
                    LPassword TEXT NOT NULL,
                    LGender TEXT NOT NULL,
                    LAddress TEXT NOT NULL,
                    CourseId INTEGER,
                    UsersId INTEGER,
                    FOREIGN KEY (UsersId) REFERENCES Users(UsersId),
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
                    CName TEXT,
                    SubjectName INTEGER,
                    LName INTEGER,
                    HName INTEGER,
                    FOREIGN KEY (CName) REFERENCES Courses(CName),
                    FOREIGN KEY (SubjectName) REFERENCES Subject(SubjectName),
                    FOREIGN KEY (LName) REFERENCES Lecturer(LName),
                    FOREIGN KEY (HName) REFERENCES Halls(HName),
                    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID),
                    FOREIGN KEY (SubjectId) REFERENCES Subject(SubjectId),  
                    FOREIGN KEY (LecturerId) REFERENCES Lecturers(LecturerId),
                    FOREIGN KEY (HallNo) REFERENCES Halls(HallNo)   

                );

                

                CREATE TABLE IF NOT EXISTS Exam (
                    EId INTEGER PRIMARY KEY AUTOINCREMENT,
                    TimeSlot TEXT NOT NULL,
                    Date TEXT NOT NULL,
                    SubjectId INTEGER,
                    SubjectName TEXT,
                    EHall TEXT NOT NULL,
                    EName TEXT NOT NULL,
                    FOREIGN KEY (SubjectName) REFERENCES Subject(SubjectName),
                    FOREIGN KEY (SubjectId) REFERENCES Subject(SubjectId)
                   
                    
                );

                CREATE TABLE IF NOT EXISTS Halls (HallNo INTEGER PRIMARY KEY,
                    RoomType TEXT NOT NULL,
                    HName TEXT NOT NULL 
                );

                CREATE TABLE IF NOT EXISTS Mark (
                    MarkID INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentId INTEGER,
                    SubjectId INTEGER,
                    EId INTEGER,
                    Score INTEGER NOT NULL,
                    SubjectName TEXT,
                    UserCode TEXT,
                    FOREIGN KEY (UserCode) REFERENCES Students(UserCode),
                    FOREIGN KEY (StudentId) REFERENCES Students(StudentId),
                    FOREIGN KEY (SubjectId) REFERENCES Subject(SubjectId),
                    FOREIGN KEY (EId) REFERENCES Exam(EId),
                    FOREIGN KEY (SubjectName) REFERENCES Subject(SubjectName)
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