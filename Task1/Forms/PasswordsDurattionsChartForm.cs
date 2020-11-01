using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Task1.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Task1.Forms
{
    public partial class PasswordsDurattionsChartForm : Task1.Forms.ChartForm
    {
        public PasswordsDurattionsChartForm(MainForm mainForm,Statistics statistics):base(mainForm,statistics)
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
        protected override void InitLabelsGroupBox()
        {
            base.InitLabelsGroupBox();
            LabelControllers.Add(new LabelController("Математическое ожидание", Statistics.GetPasswordsMathExpectasion, layoutPanel));
            LabelControllers.Add(new LabelController("Дисперсия в миллискундах", Statistics.GetPasswordsDispersion, layoutPanel));
            LabelControllers.Add(new LabelController("Среднеквадратическое отклонение", Statistics.GetPasswordsSigma, layoutPanel));
        }
        protected override void UpdateChart()
        {
            double[] yValues = mainForm.StatisticsManager.GetPasswordDurations(mainForm.PasswordActions);
            UpdateChartByData(yValues);
            
        }
       
    }
}
