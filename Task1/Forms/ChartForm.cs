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
    public abstract class ChartForm:Form
    {
        protected MainForm mainForm;
        protected Chart mainChart;
        public ChartForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            Init();
        }

        protected virtual void Init()
        {
            InitChart();
        }

        protected void InitChart()
        {
            Update();
        }
        public void Update()
        {
            UpdateChart();
            UpdateLabels();
        }
        public abstract void UpdateLabels();
        public virtual void UpdateChart()
        {
            UpdateChartByData(mainForm.StatisticsManager.GetPasswordDurations(mainForm.PasswordActions));

        }
        public virtual void UpdateChartByData(double[] values)
        {
            mainChart.Series.Last().Points.Clear();
            for (int i = 0; i < values.Length; i++)
            {
                mainChart.Series.Last().Points.AddY(TimeSpanConverter.TotalSeconds(values[i]));
            }
        }
    }
}
