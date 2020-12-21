using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Task1.main;
using Task1.PasswordsActions;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
namespace Task1
{
    public class PasswordActionRepository
    {

        DbContext context;
        DbSet<User> users;
        DbSet<PasswordAction> _passwordActions;

        public PasswordActionRepository(DbContext context)
        {
            this.context = context;
            users = context.Set<User>();
        }

        public IEnumerable<User> GetUsers()
        {
            return users.AsNoTracking().ToList();
        }

        public IEnumerable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return users.AsNoTracking().Where(predicate).ToList();
        }
        public TEntity FindById(int id)
        {
            return users.Find(id);
        }

        public void AddUser(User user)
        {
            users.Add(user);
            context.SaveChanges();
        }
        public void Update(TEntity item)
        {
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Remove(TEntity item)
        {
            users.Remove(item);
            context.SaveChanges();
        }

        public void AddPasswordAction(PasswordAction passwordAction)
        {
            users.Add(user);
            context.SaveChanges();
        }


        PasswordActionContext database;

        public ObservableCollection<PasswordAction> PasswordActions { get; protected set; }
        public ObservableCollection<User> Users { get; protected set; }
        public PasswordAction PasswordAction { get { return PasswordActions.Last(); } }

        public Settings Settings { get; }

        public PasswordActionRepository(Settings settings)
        {

            database = new PasswordActionContext();
            Settings = settings;
            database.PasswordActions.Include(passAct => passAct.SymbolActions);
            database.Users.Load();
            PasswordActions = database.PasswordActions.Local;
            database.PasswordActions.Include(passAct => passAct.SymbolActions).Where(passAct => passAct.UserId == this.Settings.User.Id).Load();
            database.PasswordActions.Where(passAct => passAct.UserId == this.Settings.User.Id).
            //PasswordActions = database.PasswordActions.Local.ToBindingList();
            Users = database.Users.Local;
            //UpdatePasswordAtions();
            //UpdateUsers();

            AbstractGroup passwordActionsGroup = new PasswordActionsGroup(PasswordActions);
            GroupBuilder groupBuilder = new GroupBuilder(passwordActionsGroup);
            GroupBuilder userGroupBuilder = groupBuilder.AppendGroup(passAct => passAct.UserId == this.Settings.User.Id);
            //повторяем для всех пользователей
            GroupBuilder samePasswordsGroupBuilder = userGroupBuilder.AppendGroup(passAct => passAct.ValidPassword == this.Settings.Password);
            //повторяем для всех паролей
            samePasswordsGroupBuilder.AppendGroupLeaf()
        }

        ~PasswordActionRepository()
        {
            database.Dispose();
            
        }

        public AbstractGroup GetPasswordActionsWithSamePassword(string password)
        {
            List<PasswordAction> passwordActions = PasswordActions.
                Where(passAct => passAct.ValidPassword == password).ToList();
            AbstractGroup group = new PasswordActionGroupLeaf(passwordActions);
            return group;
        }
        public List<PasswordAction> GetPasswordActionsByUser()
        {
            List<PasswordAction> passwordActions = PasswordActions.
                Where(passAct => passAct.UserId == this.Settings.User.Id).ToList();
            AbstractGroup group = new PasswordActionGroupLeaf(passwordActions);
            //добавить другие группы паролей
            return group;
        }
        //public void UpdatePasswordAtions()
        //{
        //    PasswordActions = database.PasswordActions. Include(passAct=> passAct.SymbolActions).
        //        Where(passAct => passAct.UserId == this.Settings.User.Id).
        //        Where(passAct=>passAct.ValidPassword==this.Settings.Password).
        //}
       
        public void InsertPasswordAction(PasswordAction passwordAction)
        {
            database.PasswordActions.Add(passwordAction);
            database.SaveChanges();
            //UpdatePasswordAtions();
        }
        public void AddUser(User user)
        {
            database.Users.Add(user);
            database.SaveChanges();
            //UpdateUsers();
        }
       
    }
}
