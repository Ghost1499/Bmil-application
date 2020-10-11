using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class PasswordManager
    {
        public enum PasswordsAlphabets
        {
            Numeral=10,
            А1 =36,//abcdefghijklmnopqrstuvwxyz0123456789
            А2 =51,//abcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()-_+=" 
            А3 =77//abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_+=} 
        }
    
        public static double CheckPasswordComplexity(string password,PasswordsAlphabets alphabet=PasswordsAlphabets.А3)
        {
            double alphLength = (double)alphabet;
            double combinations = Math.Pow(alphLength, password.Count());
            return Math.Log(combinations,2);
        }
    }
}
