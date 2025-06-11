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
            using (var Conn = Db_config.GetConnection())
            {
                var cmd = Conn.CreateCommand();
                cmd.createcommand = @" CREATE TABLE IF NOT EXITS ";
            }
            }
    }
}
