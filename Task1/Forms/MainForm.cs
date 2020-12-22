using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Task1.Exceptions;
using Task1.Forms;
using Task1.main;
using Task1.MyMath;
using Task1.Main;

namespace Task1
{
    public partial class MainForm : Form
    {
        SettingsForm settingsForm;
        public PasswordActionContext Context { get; private set; }
        public AuthenticationController AuthenticationController { get; private set; }

        //public delegate void UpdatePasswordsHandler();
        public event Action PasswordsUpdate;
        public event Action ChangeUser;

        public Settings Settings { get; set; }
        private InputController InputController { get;  set ; }

        public MainForm()
        {
            InitializeComponent();
            Settings = new Settings();
            //Repository = new PasswordActionRepository(Settings);
            Context = new PasswordActionContext();
            AuthenticationController = new AuthenticationController(Context,Settings);

            InputController = new InputController(Settings);

            Init();
        }

        private void Init()
        {
            usersListBox.DisplayMember = "Login";
            usersListBox.ValueMember = "Id";
            usersListBox.DataSource = Context.Users.Local.ToBindingList(); 

            //usersListBox.SelectedIndexChanged += usersListBox_SelectedIndexChanged;

            acceptPasswordButton.Select();

            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("en-US"));
            UpdateLabels();
            //UpdateValues();
        }
        public void UpdateLabels()
        {
            samplePasswordLabel.Text =  Settings.Password;
            passwordComplexetyLabel.Text = Math.Round(PasswordComplexity.CheckPasswordComplexity(Settings.Password, Settings.Alphabet),2).ToString();
        }
        //private void UpdateValues()
        //{
        //    mathExpectationLabel.Text = Math.Round(statistics.GetPasswordsMathExpectasion(),3).ToString();
        //    dispersionLabel.Text = Math.Round(statistics.GetPasswordsDispersion(),3).ToString();
        //    sigmaLabel.Text = Math.Round(statistics.GetPasswordsSigma(),3).ToString();
         
        //}

        private void AcceptPassword()
        {
            try
            {
                if (InputController.PasswordAction == null)
                {
                    MessageBox.Show("Введите пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                PasswordAction passwordAction = InputController.EndPasswordAction(DateTime.Now, passwordTextBox.Text);
                switch (InputController.InputMode)
                {
                    case InputMode.Input:
                        Context.PasswordActions.Add(passwordAction);
                        Context.SaveChanges();
                        PasswordsUpdate?.Invoke();
                        break;
                    case InputMode.Identify:
                        User user= AuthenticationController.IdentifyUser(passwordAction);
                        MessageBox.Show($"Идентифецирован пользователь {user.Login} с id={user.Id}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case InputMode.Verify:
                        bool result=AuthenticationController.VerifyUser(passwordAction);
                        if (result)
                        {
                            MessageBox.Show("Пользователь подтвержден", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Польльзователь не подтвержден", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        break;
                    default:
                        break;
                }
               
            }
            catch (InvalidPasswordException)
            {
                MessageBox.Show("Пароль неверный!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (BaseException)
            {
            }
        }

        private void StartTypingPassword(object sender, EventArgs e)
        {
            this.passwordTextBox.Clear();
            InputController.NextPasswordAction(Settings.Password, DateTime.Now);

        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            StartTypingPassword(sender, e);
        }

        private void acceptPasswordButton_Click(object sender, EventArgs e)
        {
            AcceptPassword();

        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                acceptPasswordButton.Focus();
                AcceptPassword();
                return;
            }
            InputController.KeyDown(e, DateTime.Now);
        }

        private void passwordTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            InputController.KeyUp(e, DateTime.Now);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsForm = new SettingsForm(this, Settings,Context);
            settingsForm.Show();
        }

        private void passwordsDurationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var passwordsDurattionsChartForm = new PasswordsDurattionsChartForm(this);
            passwordsDurattionsChartForm.Show();
        }

        private void typingDimanicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TypingDinamicChartForm typingDinamicChartForm= new TypingDinamicChartForm(this);
            //typingDinamicChartForm.Show();
        }

        private void passwordKeyPressDurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //KeysPressDurationChartForm keysPressDurationChartForm = new KeysPressDurationChartForm(this, statistics);
            //keysPressDurationChartForm.Show();
        }

        private void passwordsVelocityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordsVelocityChartForm passwordsVelocityChartForm = new PasswordsVelocityChartForm(this);
            passwordsVelocityChartForm.Show();
        }

        private void functionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FunctionChartForm functionChartForm = new FunctionChartForm(this, statistics);
            //functionChartForm.Show();
        }

        private void usersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // получаем id выделенного объекта
            int id = (int)usersListBox.SelectedValue;

            AuthenticationController.ChangeUser(id);
            
            // получаем весь выделенный объект
            //User user = (User)usersListBox.SelectedItem;
            //MessageBox.Show(value.ToString() + ". " + passwordsAlphabet.ToString());
            //Settings.User = user;
            //if (!Context.Entry(Settings.User).Collection(u => u.PasswordActions).IsLoaded)
            //{
        
            //    Context.Entry(Settings.User).Collection(u => u.PasswordActions).Load();
            //}
            
            //Repository.UpdatePasswordAtions();
            ChangeUser?.Invoke();
            //PasswordsUpdate?.Invoke();
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            int id = (int)usersListBox.SelectedValue;
            AuthenticationController.DeleteUser();
            MessageBox.Show("Пользователь удален", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

            ChangeUser?.Invoke();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked)
                return;
            // приводим отправителя к элементу типа RadioButton
            RadioButton radioButton; //= (RadioButton)sender;

            if (radioButton1.Checked)
            {
                radioButton = radioButton1;
                InputController.InputMode = InputMode.Input;
                samplePasswordLabel.Text = Settings.Password;

                MessageBox.Show("Выбран режим " + radioButton.Text);

            }
            else if (radioButton2.Checked)
            {
                radioButton = radioButton2;
                InputController.InputMode = InputMode.Identify;
                samplePasswordLabel.Text = "Введите пароль для идентификации";

                MessageBox.Show("Выбран режим " + radioButton.Text);

            }
            else if (radioButton3.Checked)
            {
                radioButton = radioButton3;
                InputController.InputMode = InputMode.Verify;
                samplePasswordLabel.Text = "Введите пароль для верификации";


                MessageBox.Show("Выбран режим " + radioButton.Text);
            }
            else throw new Exception("Ошибка с Radiobutton");
            
        }

        private void userInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userForm = new UserForm(this);
            userForm.Show();
        }
    }
}
