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
using static Task1.MyMath.PasswordComplexity;
using Task1.Exceptions;

namespace Task1.Forms
{
    public partial class SettingsForm : Form
    {
        MainForm mainForm;
        Settings settings;

        public PasswordActionContext Context { get; set; }

        public SettingsForm(MainForm mainForm, Settings settings, PasswordActionContext context)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.settings = settings;
            Context = context ?? throw new ArgumentNullException(nameof(context));
            Init();
        }

        private void Init()
        {
            passwordSampleTextBox.Text = settings.Password;
            System.Array alphabets = Enum.GetValues(typeof(PasswordsAlphabets));
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
            PasswordsAlphabets passwordsAlphabet = (PasswordsAlphabets)listBox1.SelectedItem;
            //MessageBox.Show(value.ToString() + ". " + passwordsAlphabet.ToString());
            settings.Alphabet = (PasswordsAlphabets)value;
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
                try
                {
                    mainForm.AuthenticationController.RegisterUser(login);
                    MessageBox.Show("Пользователь добавлен", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch ( BaseException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            else
            {
                MessageBox.Show("Введите логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }

}

