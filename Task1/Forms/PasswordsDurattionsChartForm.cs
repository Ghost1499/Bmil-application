using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Task1.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Task1.StatisticsInterfaces;
using Task1.Forms.Containers;
using Task1.Containers;

namespace Task1.Forms
{
    public partial class PasswordsDurattionsChartForm : Task1.Forms.ChartForm
    {
        public new IPasswordsDurationsStatistics Statistics { get; set; }
        public override void SetStatistics(Statistics value)
        {
            base.SetStatistics(value);
            Statistics = value;
        }
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
            Control parent = layoutPanel;
            IBuilder fBuilder = new ContainersBuilder(new LabelsContainer(parent));

            IBuilder builder = fBuilder.BuildContainer(parent, new GroupBox(), "Днем");
            builder.BuildElement("Математическое ожидание", Statistics.GetPasswordsMathExpectasion, layoutPanel);
            builder.BuildElement("Дисперсия в миллискундах", Statistics.GetPasswordsDispersion, layoutPanel);
            builder.BuildElement("Среднеквадратическое отклонение", Statistics.GetPasswordsSigma, layoutPanel);

            builder = fBuilder.BuildContainer(parent, new GroupBox(), "Вечером");
            builder.BuildElement("Математическое ожидание", Statistics.GetPasswordsMathExpectasion, layoutPanel);
            builder.BuildElement("Дисперсия в миллискундах", Statistics.GetPasswordsDispersion, layoutPanel);
            builder.BuildElement("Среднеквадратическое отклонение", Statistics.GetPasswordsSigma, layoutPanel);

            this.LabelsContainer = fBuilder.GetResult();
            //LabelControllers.Add(new LabelController("Математическое ожидание", Statistics.GetPasswordsMathExpectasion, layoutPanel));
            //LabelControllers.Add(new LabelController("Дисперсия в миллискундах", Statistics.GetPasswordsDispersion, layoutPanel));
            //LabelControllers.Add(new LabelController("Среднеквадратическое отклонение", Statistics.GetPasswordsSigma, layoutPanel));
        }
        protected override void UpdateChart()
        {
            double[] yValues = Statistics.GetPasswordsDurations();
            UpdateChartByData(yValues);
            
        }
       
    }
}
