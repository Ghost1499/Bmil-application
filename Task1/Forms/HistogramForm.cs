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
    public partial class HistogramForm : Form
    {
        MainForm mainForm;
        public HistogramForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            InitHistogram();
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
            UpdateHistogram();
        }


        public void UpdateHistogram()
        {
            UpdateHistogramByData(mainForm.StatisticsManager.GetPasswordDurations(mainForm.PasswordActions));

        }
        public void UpdateHistogramByData(long[] passwordsLengths)
        {
            histogramChart.Series.Last().Points.Clear();
            for (int i = 0; i < passwordsLengths.Length; i++)
            {
                histogramChart.Series.Last().Points.AddY(passwordsLengths[i]);
            }
        }
    }
}
