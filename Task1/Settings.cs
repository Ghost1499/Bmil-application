using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Settings
    {
        private string password;
        private PasswordManager.PasswordsAlphabets alphabet;

        public Settings(string password="password",PasswordManager.PasswordsAlphabets alphabet=PasswordManager.PasswordsAlphabets.А3)
        {
            this.password = password;
            this.alphabet = alphabet;
        }

        public string Password { get => password; set => password = value; }
        public PasswordManager.PasswordsAlphabets Alphabet { get => alphabet; set => alphabet = value; }
    }
}
