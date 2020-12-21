using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.main;
using Task1.Exceptions;

namespace Task1.Main
{
    public class AuthenticationController
    {
        PasswordActionContext Context { get; set; }
        public Settings Settings { get; }
        public int CurrentUserId { get; private set; }
        public AuthenticationController(PasswordActionContext context,Settings settings)
        {
            Context = context;
            Settings = settings ?? throw new ArgumentNullException(nameof(settings));
            Context.Users.Load();
            ChangeUser(Context.Users.FirstOrDefault()?.Id ?? -1);
        }

        public void ChangeUser(int newUserId)
        {
            if (newUserId == -1)
            {
                throw new Exceptions.BaseException("Users do not exist");
            }
            CurrentUserId = newUserId;
            Context.PasswordActions.Include(p => p.SymbolActions).Where(p => p.UserId == newUserId).Load();
            Settings.UserId = CurrentUserId;
            //CurrentUser = newUser;
            //if (!Context.Entry(CurrentUser).Collection(u => u.PasswordActions).IsLoaded)
            //{

            //    Context.Entry(CurrentUser).Collection(u => u.PasswordActions).Load();
            //}
        }
        public void DeleteUser()
        {
            User currentUser = Context.Users.Find(CurrentUserId);
            Context.Users.Remove(currentUser);
            //ChangeUser(Context.Users.FirstOrDefault()?.Id ?? -1);
            Context.SaveChanges();
        }

        public User IdentifyUser(PasswordAction passwordAction)
        {
            List<PasswordAction> passwordActions=
                Context.PasswordActions
                .Include(p => p.SymbolActions)
                .Where(p => p.ValidPassword == passwordAction.ValidPassword)
                .ToList();
            PasswordAction mostRelevantPasswordAction= passwordActions.FirstOrDefault(p => p.ValidPassword == passwordAction.ValidPassword);
            User user = Context.Users.Find(mostRelevantPasswordAction.UserId);
            return user;
        }

        public bool VerifyUser(PasswordAction passwordAction)
        {
            return true;
        }

        public void RegisterUser(string login)
        {
            if (!Context.Users.Any((user) => user.Login == login))
            {
                User user = new User(login);
                Context.Users.Add(user);
                Context.SaveChanges();


            }
            else
            {
                throw new BaseException("Пользователь с таким логином уже существует");

            }
        }

    }
}
