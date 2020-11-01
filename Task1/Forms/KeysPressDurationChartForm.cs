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
    public partial class KeysPressDurationChartForm : ChartForm
    {
        public KeysPressDurationChartForm(MainForm mainForm,Statistics statistics):base(mainForm,statistics)
        {
            InitializeComponent();
        }
        protected override void InitChart()
        {
            base.InitChart();
            chart.Titles[0].Text = "Длительность нажатия клавиш";
            LastSeries.ChartType = SeriesChartType.Line;

        }
        protected override void UpdateChart()
        {
            string[] xValues;
            double[] yValues;
            Statistics.GetKeysPressDuration(out xValues, out yValues);
            UpdateChartByData<string>(yValues, xValues);
        }
    }
}
