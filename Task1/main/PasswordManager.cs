using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Task1.main;

namespace Task1
{
    public class PasswordManager
    {
        PasswordActionContext database;
        //private UserContext usersDB;

        public List<PasswordAction> PasswordActions { get; protected set; }
        public List<User> Users { get; protected set; }
        public PasswordAction PasswordAction { get { return PasswordActions.Last(); } }

        public Settings Settings { get; }

        public PasswordManager(Settings settings)
        {
            database = new PasswordActionContext();
            //usersDB = new UserContext();
            //database.PasswordActions.RemoveRange(database.PasswordActions);
            //database.SaveChanges();
            Settings = settings;
            //database.PasswordActions.Load();
            Users = new List<User>(); 
            UpdatePasswordAtions();
            UpdateUsers();
            
        }

        ~PasswordManager()
        {
            database.Dispose();
        }

        public void UpdatePasswordAtions()
        {
            PasswordActions = database.PasswordActions. Include(passAct=> passAct.SymbolActions).
                Where(passAct => passAct.UserId == this.Settings.User.Id).
                Where(passAct=>passAct.ValidPassword==this.Settings.Password).ToList();
        }
        public void UpdateUsers()
        {
            Users = database.Users.ToList();
        }
        public void InsertPasswordAction(PasswordAction passwordAction)
        {
            database.PasswordActions.Add(passwordAction);
            database.SaveChanges();
            UpdatePasswordAtions();
        }
        public void AddUser(User user)
        {
            database.Users.Add(user);
            database.SaveChanges();
            UpdateUsers();
        }
        public enum PasswordsAlphabets
        {
            Numeral = 10,
            А1 = 36,//abcdefghijklmnopqrstuvwxyz0123456789
            А2 = 51,//abcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()-_+=" 
            А3 = 77//abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_+=} 
        }

        public static double CheckPasswordComplexity(string password, PasswordsAlphabets alphabet = PasswordsAlphabets.А3)
        {
            double alphLength = (double)alphabet;
            double combinations = Math.Pow(alphLength, password.Count());
            return Math.Log(combinations, 2);
        }
    }
}
