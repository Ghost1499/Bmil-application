using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1.Forms
{
    public partial class PressDurationChartForm : Form
    {
        //public PressDurationChartForm(MainForm mainForm):base(mainForm)
        //{
        //    InitializeComponent();
        //}


        //protected override void Init()
        //{
        //    this.mainChart = this.pressDurationChart;
        //}
        //public override void UpdateChart()
        //{
        //    string[] typedSymbols;
        //    UpdateChartByData(mainForm.StatisticsManager.GetTypingDinamic(mainForm.PasswordAction, out typedSymbols), typedSymbols);
        //}
        //public  void UpdateChartByData(double[] symbolsDinamic, string[] typedSymbols)
        //{
        //    mainChart.Series.Last().Points.Clear();
        //    for (int i = 0; i < symbolsDinamic.Length; i++)
        //    {
        //        mainChart.Series.Last().Points.AddXY(typedSymbols[i], TimeSpanConverter.TotalSeconds(symbolsDinamic[i]));
        //    }
        //}

        //public override void UpdateLabels()
        //{

        //}



        MainForm mainForm;
        public PressDurationChartForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            Init();
        }

        private void Init()
        {
            InitTypingDinamicLine();
        }
        public void Update()
        {
            UpdateTypingDinamicLine();
            //overlaysCountLabel.Text = mainForm.PasswordAction.OverlaysCount.ToString();
        }
        private void InitTypingDinamicLine()
        {
            Update();
        }
        public void UpdateTypingDinamicLine()
        {
            string[] typedSymbols;
            UpdateTypingDinamicLineFromData(mainForm.StatisticsManager.GetPressDuration(mainForm.PasswordAction, out typedSymbols), typedSymbols);
        }
        public void UpdateTypingDinamicLineFromData(double[] symbolsDinamic, string[] typedSymbols)
        {
            pressDurationChart.Series.Last().Points.Clear();
            for (int i = 0; i < symbolsDinamic.Length; i++)
            {
                pressDurationChart.Series.Last().Points.AddXY(typedSymbols[i], TimeSpanConverter.TotalSeconds(symbolsDinamic[i]));
            }
        }
    }
}
