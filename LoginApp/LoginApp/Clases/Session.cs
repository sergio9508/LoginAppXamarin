using System;
using System.Collections.Generic;
using System.Text;

namespace LoginApp.Clases
{
    public class Session
    {
        public bool isActive { get; set; }
        public string token { get; set; }
        public string errors { get; set; }
        public Session() { }
    }
}
