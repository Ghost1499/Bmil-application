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
            mainForm.PasswordsUpdate += UpdateForm;
            Init();
        }

        private void Init()
        {
            InitTypingDinamicLine();
        }
        public void UpdateForm()
        {
            UpdateTypingDinamicLine();
            //overlaysCountLabel.Text = mainForm.PasswordAction.OverlaysCount.ToString();
        }
        private void InitTypingDinamicLine()
        {
            UpdateForm();
        }
        public void UpdateTypingDinamicLine()
        {
            string[] typedSymbols;
            double[] result;
            mainForm.StatisticsManager.GetKeysPressDuration(out typedSymbols, out result);
            UpdateTypingDinamicLineFromData(result, typedSymbols);
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
