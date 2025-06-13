using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicManagementSystem.Method
{
    internal class Users
    {

        public enum Roles
        {
            Admin = 1,
            Lecturer = 2,
            Staff = 3,
            Student = 4,

        }
        public class RoleObtion
        {
            public int roleId { get; set; }
            public string roleName { get; set; }
        }
    }
}

