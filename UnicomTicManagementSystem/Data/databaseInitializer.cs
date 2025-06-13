using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicManagementSystem.Data
{
    public static class databaseInitializer
    {
        public static void createtable()
            {
            using (var Conn = DbConfig.GetConnection())
            {
                var cmd = Conn.CreateCommand();
                cmd.CommandText = @" CREATE TABLE IF NOT EXSITS Admin ( AdminId INTEGER PRIMARY KEY AUTOIMCREMENT,
                                    Name TEXT NOT NULL , Password TEXT NOT NULL ,Gender TEXT NOT NULL, Role TEXT NOT NULL);

                            CREATE TABLE IF NOT EXITS Courses (CourseID INTEGER  PRIMARY KEY AUTOIMCREMENT,
                            Name TEXT NOT NULL , Password TEXT NOT NULL );

                            CREATE TABLE IF NOT EXISTS Subject ( SubjectId INTEGER PRIMARY KEY AUTOINCREMENT,
                            SubjectName TEXT NOT NULL , CourseId INTEGER , FOREIGN KEY (CourseId) REFERENCES Courses );

                            CREATE TABLE IF NOT EXISTS Students (
                            StudentId INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name TEXT NOT NULL,
                            Password TEXT NOT NULL,
                            Gender TEXT NOT NULL);

                            CREATE TABLE IF NOT EXITS Lecturer (LacturerId INTEGER PRIMARY KEY AUTOINCREMENT
                            ,Name TEXT NOT NULL, Password TEXT NOT NULL , Gender TEXT NOT NULL);

                            CREATE TABLE IF NOT EXITS Staff (StaffId INTEGER PRIMARY KEY AUTOINCERMRNT
                            ,Name TEXT NOT NULL , Password TEXT NOT NULL ,Gender TEXT NOT NULL);

                                                ";
            }
            }
    }
}
