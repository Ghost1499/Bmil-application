using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task1.main;

namespace Task1.Forms
{
    public partial class SettingsForm : Form
    {
        MainForm mainForm;
        Settings settings;
        public SettingsForm(MainForm mainForm, Settings settings)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.settings = settings;
            Init();
        }

        private void Init()
        {
            passwordSampleTextBox.Text = settings.Password;
            System.Array alphabets = Enum.GetValues(typeof(PasswordManager.PasswordsAlphabets));
            listBox1.DataSource = alphabets;
            listBox1.DisplayMember = "Name";
            //listBox1.ValueMember = "Value";

            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // получаем id выделенного объекта
            int value = (int)listBox1.SelectedValue;

            // получаем весь выделенный объект
            PasswordManager.PasswordsAlphabets passwordsAlphabet = (PasswordManager.PasswordsAlphabets)listBox1.SelectedItem;
            //MessageBox.Show(value.ToString() + ". " + passwordsAlphabet.ToString());
            settings.Alphabet = (PasswordManager.PasswordsAlphabets)value;
            mainForm.UpdateLabels();

        }

        //private void passwordSampleTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    settings.Password = passwordSampleTextBox.Text;
        //    mainForm.UpdateLabels();
        //}

        private void acceptPasswordSampleButton_Click(object sender, EventArgs e)
        {
            settings.Password = passwordSampleTextBox.Text;
            mainForm.UpdateLabels();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            string login = newUserTextBox.Text;
            if (login != "")
            {
                if (!mainForm.PasswordManager.Users.Any((user) => user.Login == login))
                {
                    User user = new User(login);
                    mainForm.PasswordManager.AddUser(user);
                    MessageBox.Show("Пользователь добавлен", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Пользователь с таким логином уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Введите логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }

}

