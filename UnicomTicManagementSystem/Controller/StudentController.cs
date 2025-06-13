using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicManagementSystem.Data;
using UnicomTicManagementSystem.Method;

namespace UnicomTicManagementSystem.Controller
{
    internal class StudentController
    {
        public void Insertstudent (Student student)
        {

            using (var conn = DbConfig.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INTSERT INTO Students (Name,Password,Address,Gender  VALUES (@name ,@password,@addresss,@gender) ";
                cmd.Parameters.AddWithValue("@name", student.Name);
                cmd.Parameters.AddWithValue("@password", student.Password);
                cmd.Parameters.AddWithValue("@address", student.Address);
                cmd.Parameters.AddWithValue("@gender", student.Gender);
            }
        }
       

    }
}
