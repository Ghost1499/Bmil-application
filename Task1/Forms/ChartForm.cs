using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Task1.Containers;

namespace Task1.Forms
{
    public abstract partial class ChartForm : Form
    {
        protected FlowLayoutPanel layoutPanel;
        protected Chart chart;

        protected MainForm mainForm;

        protected LabelsContainer LabelsContainer { get; set; }
        protected List<LabelElement> LabelElements { get; set; }
        public Settings Settings { get { return mainForm.Settings; } }

        public ChartForm(MainForm mainForm)
        {
            InitializeComponent();
            chart = mainChart;
            layoutPanel = mainFlowLayoutPanel;


            this.mainForm = mainForm;

            //mainForm.Context.PasswordActions.Local.CollectionChanged += UpdateForm;
            mainForm.PasswordsUpdate += UpdateForm;
            mainForm.ChangeUser += ReloadData;
            Init();
        }

        protected virtual void Init()
        {
            InitChart();
            InitLabelsGroupBox();
            UpdateForm();
        }
        protected abstract void LoadData();
        protected abstract void ReloadData();
        protected virtual void InitChart()
        {

        }
        protected virtual void InitLabelsGroupBox()
        {
            LabelElements = new List<LabelElement>();
        }

        protected virtual void UpdateForm(/*object sender = null, NotifyCollectionChangedEventArgs e = null*/)
        {
            LoadData();
            UpdateChart();
            UpdateLablesGroupBox();
        }

        //public abstract void Clear();
        protected abstract void UpdateChart();




        //public void UpdateChartByData<T>(double[] yValues, T[] xValues)
        //{
        //    LastSeries.Points.Clear();
        //    for (int i = 0; i < yValues.Length; i++)
        //    {
        //        LastSeries.Points.AddXY(FormatX(xValues[i]), FormatY(yValues[i]));
        //    }
        //}

        //protected void UpdateChartByData(double[] yValues)
        //{
        //    LastSeries.Points.Clear();
        //    for (int i = 0; i < yValues.Length; i++)
        //    {
        //        LastSeries.Points.AddY(FormatY(yValues[i]));
        //    }
        //}

        protected virtual double FormatY(double value)
        {
            return value;
        }
        protected virtual T FormatX<T>(T value)
        {
            return value;
        }

        protected  void UpdateLablesGroupBox()
        {
            foreach (var item in LabelElements)
            {
                item.Update();
            }
            //LabelsContainer.Update();
        }

        protected void ChartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.PasswordsUpdate -= UpdateForm;
        }
    }
}
