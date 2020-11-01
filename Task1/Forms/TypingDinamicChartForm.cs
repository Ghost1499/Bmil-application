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
    public partial class TypingDinamicChartForm : ChartForm
    {
        public TypingDinamicChartForm(MainForm mainForm,Statistics statistics):base(mainForm,statistics)
        {
            InitializeComponent();
        }
        protected override void InitChart()
        {
            base.InitChart();
            chart.Titles[0].Text = "Динамика ввода";
            LastSeries.ChartType = SeriesChartType.Line;

        }
        protected override void InitLabelsGroupBox()
        {
            base.InitLabelsGroupBox();
            LabelControllers.Add(new LabelController("Количество наложений", Statistics.GetOverlaysCount, layoutPanel));
        }
        protected override void UpdateChart()
        {
            string[] xValues;
            double[] yValues;
            Statistics.GetPasswordTypingDinamic(out xValues, out yValues);
            UpdateChartByData<string>(yValues, xValues);
        }
    }
}
