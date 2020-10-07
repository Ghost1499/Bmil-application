using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Settings
    {
        private string password;

        public Settings(string password="password")
        {
            this.password = password;
        }

        public string Password { get => password; set => password = value; }
    }
}
