﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Task1.StatisticsInterfaces;


namespace Task1.Forms
{
    public partial class KeysPressDurationChartForm : ChartForm
    {
        public new IKeysPressDurationStatistics Statistics { get; set; }
        public override void SetStatistics(Statistics value)
        {
            base.SetStatistics(value);
            Statistics = value;
        }

        public KeysPressDurationChartForm(MainForm mainForm,Statistics statistics):base(mainForm,statistics)
        {
            InitializeComponent();
            Statistics = statistics;
            
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
            Statistics.GetKeysPressDurations(out xValues, out yValues);
            UpdateChartByData<string>(yValues, xValues);
        }
    }
}