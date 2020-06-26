using System;
using System.Collections.Generic;
using System.Text;

namespace LoginApp.Clases
{
    public class NuevoUsuario
    {
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string[] roles { get; set; }
        public NuevoUsuario(string Name, string Password, string Email)
        {
            this.username = Name;
            this.password = Password;
            this.email = Email;
            this.roles = new string[] { "admin", "user"};
        }
    }
}
