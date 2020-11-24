using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.main;

namespace Task1
{
    public class Settings
    {
        private string password;
        private PasswordManager.PasswordsAlphabets alphabet;
        private User user;

        public Settings(string password="password",PasswordManager.PasswordsAlphabets alphabet=PasswordManager.PasswordsAlphabets.А3,User user=null)
        {
            this.password = password;
            this.alphabet = alphabet;
            if (user ==null)
            {
                User = new User("default");
            }
            else
            {

                User = user;
            }
        }

        public string Password { get => password; set => password = value; }
        public PasswordManager.PasswordsAlphabets Alphabet { get => alphabet; set => alphabet = value; }
        public User User { get => user; set => user = value; }
    }
}
