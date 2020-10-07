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

namespace Task1
{
    public partial class MainForm : Form
    {
        InputController inputController;
        Settings settings;
        StatisticsManager statisticsManager;
        public MainForm()
        {
            InitializeComponent();
            settings = new Settings();
            inputController = new InputController();
            statisticsManager = new StatisticsManager(inputController.PasswordActions);
            Init();

            double[] vals = new double[] { 1, 2, 3, 10 };
            label1.Text = StatisticsManager.MathExpectation(vals).ToString();
            label2.Text = StatisticsManager.Dispersion(vals).ToString();
        }

        private void Init(int passwordVelocityTimerInteral=10)
        {          
            InitHistogram();
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("en-US"));

            //InputLanguage.CurrentInputLanguage=lan
        }

        private void InitHistogram()
        {
            //this.histogramChart.ChartAreas.Add(new ChartArea("Histogram area"));
            Series histogramSeries = new Series("Длительность набора парольной фразы в секундах");
            histogramSeries.ChartType = SeriesChartType.Column;
            //histogramSeries.Points.AddXY(1, 5);
            //histogramSeries.Points.AddXY(2, 4);
            histogramChart.Series.Clear();
            histogramChart.Series.Add(histogramSeries);
            UpdateHistogram(statisticsManager.GetPasswordDurations());
        }

        private void UpdateTypingDinamicLine(long[] symbolsDinamic)
        {
            typingDinamicChart.Series.Last().Points.Clear();
            for (int i = 0; i < symbolsDinamic.Length; i++)
            {
                typingDinamicChart.Series.Last().Points.AddY(symbolsDinamic[i]);
            }
        }

        private void UpdateHistogram(long[] passwordsLengths)
        {
            histogramChart.Series.Last().Points.Clear();
            for (int i = 0; i < passwordsLengths.Length; i++)
            {
                histogramChart.Series.Last().Points.AddY(passwordsLengths[i]);
            }
        }

        private void AcceptPassword()
        {

            inputController.EndPasswordAction(DateTime.Now);
            UpdateHistogram(statisticsManager.GetPasswordDurations());
            UpdateTypingDinamicLine(statisticsManager.GetTypingDinamic(inputController.PasswordAction));
            //label1.Text = statisticsManager.GetPasswordMathExpectasion(statisticsManager.GetPasswordDurations()).ToString();
            //label2.Text = statisticsManager.GetPasswordDispersion(statisticsManager.GetPasswordDurations()).ToString();
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


        //private int PasswordAccepted()
        //{
        //    return passwordVelocityTimer.
        //}
    }
}
