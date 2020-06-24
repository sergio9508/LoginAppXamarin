using System;
using System.Collections.Generic;
using System.Text;

namespace LoginApp.Clases
{
    public class NewUser
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string[] Role { get; set; }
        public NewUser(string Name, string Password, string Email, string[] Role)
        {
            this.Name = Name;
            this.Password = Password;
            this.Email = Email;
            this.Role = Role;
        }
    }
}
