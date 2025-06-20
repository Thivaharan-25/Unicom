﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicManagementSystem.Method
{
    internal class Users
    {
        public int Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string Gender { get; set; }
        public string Role { get; set; }
        public string Course { get; set; }
        
        public string UserCode { get; set; }




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

        public class Credentials
        {
            public string userName { get; set; }
            public string password { get; set; }
        }
        public static class Session
        {
            public static Users LoggedInUser { get; set; }
            public static string UserCode { get; set; }
            public static string Role { get; set; }
        }

    }
}

