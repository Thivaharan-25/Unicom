using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicManagementSystem.Data
{
    internal class Db_config
    {
        public static class DbCon
        {
            private static string connectionString = "Data Source=Unicom.db;Version=3;";

            public static SQLiteConnection GetConnection()
            {
                SQLiteConnection conn = new SQLiteConnection(connectionString);
                conn.Open();
                return conn;
            }
        }
    }
}
