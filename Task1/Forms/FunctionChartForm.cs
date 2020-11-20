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

namespace Task1.Forms
{
    public partial class FunctionChartForm : ChartForm
    {
        public FunctionChartForm(MainForm mainForm, Statistics statistics) : base(mainForm, statistics)
        {
            InitializeComponent();
        }

        protected override void InitChart()
        {
            base.InitChart();
            chart.Titles[0].Text = "Функция f(x)";
            LastSeries.ChartType = SeriesChartType.StepLine;
            LastSeries.BorderWidth = 3;
            chart.ChartAreas[0].AxisY.Interval = 1;
            chart.ChartAreas[0].AxisY.Minimum = 0;
            chart.ChartAreas[0].AxisY.Maximum = 2;

            chart.ChartAreas[0].AxisX.Interval = 0.1;
            chart.ChartAreas[0].AxisX.Minimum = 0;
            chart.ChartAreas[0].AxisX.Maximum = 1;

        }
        protected override void UpdateChart()
        {
            SortedDictionary<double, int> function = mainForm.StatisticsManager.PasswordAction.NormalizedFunction();
            double[] yValues;
            yValues=Array.ConvertAll(function.Values.ToArray(),(val)=>(double)val);
            UpdateChartByData(yValues, function.Keys.Select((val) => Math.Round(val, 2)).ToArray());
        }
    }
}
