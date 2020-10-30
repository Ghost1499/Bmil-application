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
        StatisticsManager statisticsManager;
        List<PasswordAction> passwordActions;
        HistogramForm histogramForm;
        PasswordDinamicForm dinamicForm;
        PressDurationChartForm pressDurationChartForm;
        SettingsForm settingsForm;

        public StatisticsManager StatisticsManager { get => statisticsManager; set => statisticsManager = value; }
        public List<PasswordAction> PasswordActions { get => passwordActions; set => passwordActions = value; }
        public PasswordAction PasswordAction {
            get {
                if (passwordActions.Count() > 0)
                {
                    return passwordActions.Last();
                }
                else return null;
            } }

        internal Settings Settings { get => settings; set => settings = value; }

        public MainForm()
        {
            InitializeComponent();
            settings = new Settings("passWoRdtoTESt1882#!",PasswordManager.PasswordsAlphabets.А3);
            inputController = new InputController();
            statisticsManager = new StatisticsManager();
            passwordActions = new List<PasswordAction>();
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
        }
        public void UpdateLabels()
        {
            samplePasswordLabel.Text = settings.Password;
            passwordComplexetyLabel.Text = PasswordManager.CheckPasswordComplexity(settings.Password, settings.Alphabet).ToString();
        }
        private void UpdateValues()
        {
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
            mathExpectationLabel.Text = TimeSpanConverter.TotalSeconds(statisticsManager.GetPasswordsMathExpectasion(statisticsManager.GetPasswordDurations(passwordActions))).ToString();
            dispersionLabel.Text = statisticsManager.GetPasswordsDispersion(statisticsManager.GetPasswordDurations(passwordActions)).ToString();
            sigmaLabel.Text = TimeSpanConverter.TotalSeconds(statisticsManager.GetPasswordsSigma(statisticsManager.GetPasswordDurations(passwordActions))).ToString();
         
        }



        private void AcceptPassword()
        {
            try
            {
                if (inputController.PasswordAction == null)
                {
                    MessageBox.Show("Введите пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                passwordActions.Add(inputController.EndPasswordAction(DateTime.Now, passwordTextBox.Text));
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

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            histogramForm = new HistogramForm(this);
            histogramForm.Show();
        }

        private void passwordDinamicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dinamicForm = new PasswordDinamicForm(this);
            dinamicForm.Show();
        }

        private void keyPressDurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pressDurationChartForm = new PressDurationChartForm(this);
            pressDurationChartForm.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsForm = new SettingsForm(this, settings);
            settingsForm.Show();
        }



        //private int PasswordAccepted()
        //{
        //    return passwordVelocityTimer.
        //}
    }
}
