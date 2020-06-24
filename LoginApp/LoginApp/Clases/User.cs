using System;
using System.Collections.Generic;
using System.Text;

namespace LoginApp.Clases
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public User(string Name, string Password)
        {
            this.username = Name;
            this.password = Password;
        }
    }
    
}
