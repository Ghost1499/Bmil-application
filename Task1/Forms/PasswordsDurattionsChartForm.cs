using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Task1.Forms;
using System.Windows.Forms.DataVisualization.Charting;
<<<<<<< HEAD
using Task1.StatisticsInterfaces;
=======
>>>>>>> 9680844b32b96d6de35f6916d7f3ebb952050b53

namespace Task1.Forms
{
    public partial class PasswordsDurattionsChartForm : Task1.Forms.ChartForm
    {
<<<<<<< HEAD
        public new IPasswordsDurationsStatistics Statistics { get; set; }
        public override void SetStatistics(Statistics value)
        {
            base.SetStatistics(value);
            Statistics = value;
        }
        public PasswordsDurattionsChartForm(MainForm mainForm,Statistics statistics):base(mainForm,statistics)
=======
        public PasswordsDurattionsChartForm(MainForm mainForm):base(mainForm)
>>>>>>> 9680844b32b96d6de35f6916d7f3ebb952050b53
        {
            InitializeComponent();
        }
        protected override void InitChart()
        {
            base.InitChart();
            //SeriesCollection series = Series;
            mainChart.Titles[0].Text = "Длительность набора парольной фразы в секундах";
            LastSeries.ChartType = SeriesChartType.Column;

        }
<<<<<<< HEAD
        protected override void InitLabelsGroupBox()
        {
            base.InitLabelsGroupBox();
            LabelControllers.Add(new LabelController("Математическое ожидание", Statistics.GetPasswordsMathExpectasion, layoutPanel));
            LabelControllers.Add(new LabelController("Дисперсия в миллискундах", Statistics.GetPasswordsDispersion, layoutPanel));
            LabelControllers.Add(new LabelController("Среднеквадратическое отклонение", Statistics.GetPasswordsSigma, layoutPanel));
        }
        protected override void UpdateChart()
        {
            double[] yValues = Statistics.GetPasswordsDurations();
=======

        protected override void UpdateChart()
        {
            double[] yValues = mainForm.StatisticsManager.GetPasswordDurations(mainForm.PasswordActions);
>>>>>>> 9680844b32b96d6de35f6916d7f3ebb952050b53
            UpdateChartByData(yValues);
            
        }
       
    }
}
