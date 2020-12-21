using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.main;
using static Task1.MyMath.PasswordComplexity;

namespace Task1
{
    public class Settings
    {
        private string password;
        private PasswordsAlphabets alphabet;
        public int UserId { get; set; }
        public InputMode InputMode { get; set; }


        public Settings(string password="password",PasswordsAlphabets alphabet=PasswordsAlphabets.А3, InputMode inputMode=InputMode.Input)
        {
            this.password = password;
            this.alphabet = alphabet;
            InputMode = inputMode;
        }

        public string Password { get => password; set => password = value; }
        public PasswordsAlphabets Alphabet { get => alphabet; set => alphabet = value; }
    }
}
