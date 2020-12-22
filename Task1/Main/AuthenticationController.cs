using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.main;
using Task1.Exceptions;
using Task1.MyMath;

namespace Task1.Main
{
    public class AuthenticationController
    {
        PasswordActionContext Context { get; set; }
        public Settings Settings { get; }
        public int CurrentUserId { get; private set; }
        public AuthenticationController(PasswordActionContext context, Settings settings)
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

        public User IdentifyUser(PasswordAction passwordAction, out double m, out double duration,out double different)
        {
            m = 0;
            different = 0;

            duration = TimeSpanConverter.TotalSeconds(passwordAction.TimeDuration);
            List<User> users = new List<User>();
            using (PasswordActionContext tempContext = new PasswordActionContext())
            {
                //tempContext.PasswordActions.Where(p => p.ValidPassword == passwordAction.ValidPassword);
                //tempContext.Users.Any( .Load();
                users = tempContext.Users.Include(u => u.PasswordActions).ToList();
            }

            List<User> newUsers = new List<User>();
            foreach (var user in users)
            {
                if(user.PasswordActions.Any(p => p.ValidPassword == passwordAction.ValidPassword)){
                    newUsers.Add(user);
                }
            }

            User identifyUser = null;
            if (newUsers.Count == 0)
                return identifyUser;
            foreach (var tempUser in newUsers)
            {

                using (PasswordActionContext newTempContext = new PasswordActionContext())
                {
                    newTempContext.PasswordActions
                        .Include(p => p.SymbolActions)
                        .Where(p => p.UserId == tempUser.Id)
                        .Load();
                    DurationsStatistics statistics = new DurationsStatistics(newTempContext.PasswordActions.Local);

                    if (identifyUser == null || Math.Abs(statistics.MathExpectation - duration) < different)
                    {
                        m = statistics.MathExpectation;
                        different = Math.Abs(m - duration);
                        identifyUser = tempUser;

                    }
                }
            }
            return identifyUser;

            //    tempContext.Users
            //    .Include(u => u.PasswordActions)
            //    .Include(u => u.PasswordActions.Select(p => p.SymbolActions))
            //    .Load();
            //}
            //return true;

            //PasswordAction mostRelevantPasswordAction = passwordActions.FirstOrDefault(p => p.ValidPassword == passwordAction.ValidPassword);
            //User user = Context.Users.Find(mostRelevantPasswordAction.UserId);
            //return user;
        }

        public bool VerifyUser(PasswordAction passwordAction, out double m, out double sigma, out double duration)
        {
            using (PasswordActionContext tempContext = new PasswordActionContext())
            {
                m = 0;
                sigma = 0;
                duration = TimeSpanConverter.TotalSeconds(passwordAction.TimeDuration);

                //bool result = true;
                tempContext.PasswordActions
                    .Include(p => p.SymbolActions)
                    .Where(p => p.UserId == passwordAction.UserId)
                    .Where(p => p.ValidPassword == passwordAction.ValidPassword)
                    .Load();

                if (tempContext.PasswordActions.Local.Count == 0)
                {
                    //result = false;
                    return false;

                }

                DurationsStatistics durationStatistics = new DurationsStatistics(tempContext.PasswordActions.Local);
                m = durationStatistics.MathExpectation;
                sigma = durationStatistics.Sigma;
                if (Math.Abs(m - duration) > sigma)
                {
                    return false;
                }

            }
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
