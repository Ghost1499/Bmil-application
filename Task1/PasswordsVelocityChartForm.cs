using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task1.Forms;
using Task1.StatisticsInterfaces;
using System.Windows.Forms.DataVisualization.Charting;

namespace Task1
{
    public partial class PasswordsVelocityChartForm : ChartForm
    {
        public IPasswordVelocityStatistics Statistics { get; set; }
        public override void SetStatistics(Statistics value)
        {
            base.SetStatistics(value);
            Statistics = value;
        }
        public PasswordsVelocityChartForm(MainForm mainForm,Statistics statistics):base(mainForm,statistics)
        {
            InitializeComponent();
        }
        protected override void InitChart()
        {
            base.InitChart();
            //SeriesCollection series = Series;
            mainChart.Titles[0].Text = "Скорость набора парольной фразы";
            mainChart.ChartAreas.Last().AxisY.Title = "символов в секунду";
            LastSeries.ChartType = SeriesChartType.Column;

        }
        protected override void InitLabelsGroupBox()
        {
            base.InitLabelsGroupBox();
            LabelControllers.Add(new LabelController("Математическое ожидание", Statistics.GetPasswordsVelocityMathExpectasion, layoutPanel));
            LabelControllers.Add(new LabelController("Дисперсия в миллискундах", Statistics.GetPasswordsVelocityDispersion, layoutPanel));
            LabelControllers.Add(new LabelController("Среднеквадратическое отклонение", Statistics.GetPasswordsVelocitySigma, layoutPanel));
        }
        protected override void UpdateChart()
        {
            double[] yValues = Statistics.GetPasswordsVelocity();
            UpdateChartByData(yValues);

        }

    }
}
