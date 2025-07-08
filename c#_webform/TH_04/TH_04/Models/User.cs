using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TH_04.Models
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string fullName { get; set; }

        public User(string username, string password, string fullName)
        {
            this.username = username;
            this.password = password;
            this.fullName = fullName;
        }
        public User() { }
    }
}