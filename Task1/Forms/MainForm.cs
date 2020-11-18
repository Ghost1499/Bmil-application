using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Task1.Exceptions;
using Task1.Forms;

namespace Task1
{
    public partial class MainForm : Form
    {
        InputController inputController;
        Settings settings;
<<<<<<< HEAD
        Statistics statistics;
        //HistogramForm histogramForm;
        //PasswordDinamicForm dinamicForm;
        //PressDurationChartForm pressDurationChartForm;
=======
        StatisticsManager statisticsManager;
        List<PasswordAction> passwordActions;
        HistogramForm histogramForm;
        PasswordDinamicForm dinamicForm;
        PressDurationChartForm pressDurationChartForm;
>>>>>>> 9680844b32b96d6de35f6916d7f3ebb952050b53
        PasswordsDurattionsChartForm passwordsDurattionsChartForm;
        SettingsForm settingsForm;

        public delegate void UpdatePasswordsHandler();
        public event UpdatePasswordsHandler PasswordsUpdate;

        public Statistics StatisticsManager { get => statistics; set => statistics = value; }

        public List<PasswordAction> PasswordActions => PasswordManager.PasswordActions;
        public PasswordAction PasswordAction { get { return PasswordActions.Last(); } }

        //public PasswordAction PasswordAction {
        //    get {
        //        if (passwordActions.Count() > 0)
        //        {
        //            return passwordActions.Last();
        //        }
        //        else return null;
        //    } }

        internal Settings Settings { get => settings; set => settings = value; }
        public PasswordManager PasswordManager { get; set; }

        public MainForm()
        {
            InitializeComponent();
            settings = new Settings();
<<<<<<< HEAD
            PasswordManager = new PasswordManager(settings);
            //PasswordActions = PasswordManager.PasswordActions;
           
=======
>>>>>>> 9680844b32b96d6de35f6916d7f3ebb952050b53
            //settings = new Settings("passWoRdtoTESt1882",PasswordManager.PasswordsAlphabets.А3);
            inputController = new InputController();
            statistics = new Statistics(PasswordManager);
            //passwordActions = new List<PasswordAction>();
            Init();

            //double[] vals = new double[] { 1, 2, 3, 10 };
            //label1.Text = StatisticsManager.MathExpectation(vals).ToString();
            //label2.Text = StatisticsManager.Dispersion(vals).ToString();
        }

        private void Init()
        {
            acceptPasswordButton.Select();
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("en-US"));
            UpdateLabels();
            UpdateValues();
        }
        public void UpdateLabels()
        {
            samplePasswordLabel.Text =  settings.Password;
            passwordComplexetyLabel.Text = Math.Round(PasswordManager.CheckPasswordComplexity(settings.Password, settings.Alphabet),2).ToString();
        }
        private void UpdateValues()
        {
<<<<<<< HEAD
            //if (histogramForm != null)
            //{
            //    histogramForm.UpdateHistogram();

            //}
            //if (dinamicForm != null)
            //{
            //    dinamicForm.Update();
            //}
            //if (pressDurationChartForm != null)
            //{
            //    pressDurationChartForm.Update();
            //}
            //if (passwordsDurattionsChartForm != null)
            //{
            //    passwordsDurattionsChartForm.UpdateForm();
            //}
            mathExpectationLabel.Text = Math.Round(statistics.GetPasswordsMathExpectasion(),3).ToString();
            dispersionLabel.Text = Math.Round(statistics.GetPasswordsDispersion(),3).ToString();
            sigmaLabel.Text =Math.Round(statistics.GetPasswordsSigma(),3).ToString();
=======
            if (histogramForm != null)
            {
                histogramForm.UpdateHistogram();

            }
            if (dinamicForm != null)
            {
                dinamicForm.Update();
            }
            if (pressDurationChartForm != null)
            {
                pressDurationChartForm.Update();
            }
            if (passwordsDurattionsChartForm != null)
            {
                passwordsDurattionsChartForm.UpdateForm();
            }
            mathExpectationLabel.Text = TimeSpanConverter.TotalSeconds(statisticsManager.GetPasswordsMathExpectasion(statisticsManager.GetPasswordDurations(passwordActions))).ToString();
            dispersionLabel.Text = statisticsManager.GetPasswordsDispersion(statisticsManager.GetPasswordDurations(passwordActions)).ToString();
            sigmaLabel.Text = TimeSpanConverter.TotalSeconds(statisticsManager.GetPasswordsSigma(statisticsManager.GetPasswordDurations(passwordActions))).ToString();
>>>>>>> 9680844b32b96d6de35f6916d7f3ebb952050b53
         
        }



        private void AcceptPassword()//сделать события
        {
            try
            {
                if (inputController.PasswordAction == null)
                {
                    MessageBox.Show("Введите пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                PasswordAction passwordAction = inputController.EndPasswordAction(DateTime.Now, passwordTextBox.Text);
                PasswordManager.InsertPasswordAction(passwordAction);
                PasswordsUpdate?.Invoke();
                //passwordActions.Add(inputController.EndPasswordAction(DateTime.Now, passwordTextBox.Text));
                UpdateValues();
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
            inputController.NextPasswordAction(settings.Password, DateTime.Now);

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
            inputController.KeyDown(e, DateTime.Now);
        }

        private void passwordTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            inputController.KeyUp(e, DateTime.Now);
        }

        //private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    histogramForm = new HistogramForm(this,StatisticsManager);
        //    histogramForm.Show();
        //}

        //private void passwordDinamicToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    dinamicForm = new PasswordDinamicForm(this);
        //    dinamicForm.Show();
        //}

        //private void keyPressDurationToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    pressDurationChartForm = new PressDurationChartForm(this);
        //    pressDurationChartForm.Show();
        //}

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsForm = new SettingsForm(this, settings);
            settingsForm.Show();
        }

        private void passwordsDurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            passwordsDurattionsChartForm = new PasswordsDurattionsChartForm(this,StatisticsManager);
            passwordsDurattionsChartForm.Show();
        }

        private void typingDimanicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypingDinamicChartForm typingDinamicChartForm= new TypingDinamicChartForm(this,statistics);
            typingDinamicChartForm.Show();
        }

        private void passwordKeyPressDurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeysPressDurationChartForm keysPressDurationChartForm = new KeysPressDurationChartForm(this, statistics);
            keysPressDurationChartForm.Show();
        }

        private void passwordsVelocityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordsVelocityChartForm passwordsVelocityChartForm = new PasswordsVelocityChartForm(this, statistics);
            passwordsVelocityChartForm.Show();
        }

        private void passwordsDurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            passwordsDurattionsChartForm = new PasswordsDurattionsChartForm(this);
            passwordsDurattionsChartForm.Show();
        }



        //private int PasswordAccepted()
        //{
        //    return passwordVelocityTimer.
        //}
    }
}
