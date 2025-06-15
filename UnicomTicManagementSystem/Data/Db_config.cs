using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicManagementSystem.Data

    {
        public static class DbConfig
        {
            private static string connectionString = "Data Source=System.db;Version=3;";

            public static SQLiteConnection GetConnection()
            {
                SQLiteConnection conn = new SQLiteConnection(connectionString);
                conn.Open();
                return conn;
            }
            //try
            //    {
            //        using (var conn = DbConfig.GetConnection())
            //        {
            //            conn.Open();
            //            var cmd = new SQLiteCommand(tableQueries, conn);
            //            cmd.ExecuteNonQuery();
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Error during table creation: " + ex.Message);
            //    }

        }
    }

