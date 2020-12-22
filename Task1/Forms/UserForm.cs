using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task1;
using System.Data.Entity;
using Task1.main;

namespace Task1.Forms
{
    public partial class UserForm : Form
    {
        public MainForm MainForm { get; set; }
        private Settings Settings { get { return MainForm.Settings; }  }
        PasswordActionContext Context { get; set; }
        User CurrentUser { get; set; }

        public UserForm(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
            mainForm.PasswordsUpdate += AddPassword;
            mainForm.ChangeUser += ChangeUser;

            ChangeUser();
        }

        ~UserForm()
        {
            DisposeContext();
        }
       

        private void AddPassword()
        {
            LoadData();
        }
        private void ChangeUser()
        {
            DisposeContext();
            Context = new PasswordActionContext();
            Context.PasswordActions.Include(p => p.SymbolActions)
                .Where(p => p.UserId == Settings.UserId)
                .Where(p => p.ValidPassword == Settings.Password)
                .Load();
            CurrentUser = Context.Users.Find(Settings.UserId);
            idLabel.Text = CurrentUser.Id.ToString();
            loginLabel.Text = CurrentUser.Login.ToString();
            passwordActionsGridView.DataSource = Context.PasswordActions.Local;
        }

        private void LoadData()
        {
            Context.PasswordActions.Include(p => p.SymbolActions)
                .Where(p => p.UserId == Settings.UserId)
                .Where(p => p.ValidPassword == Settings.Password)
                .Load();
        }

        private void DisposeContext()
        {
            if(Context!= null)
                Context.Dispose();
        }
    }
}
