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
using Task1.StatisticsInterfaces;

namespace Task1.Forms
{
    public abstract partial class ChartForm : Form
    {
        protected FlowLayoutPanel layoutPanel;
        protected Chart chart;

        protected MainForm mainForm;
        protected Series LastSeries
        {
            get
            {
                return chart.Series.Last();
            }
        }
        protected SeriesCollection Series
        {
            get { return chart.Series; }
        }

        private Statistics statistics;

        public virtual Statistics GetStatistics()
        {
            return statistics;
        }

        public virtual void SetStatistics(Statistics value)
        {
            statistics = value;
        }

        protected List<IUpdatable> LabelControllers { get; set; }


        public ChartForm(MainForm mainForm, Statistics statistics)
        {
            InitializeComponent();
            chart = mainChart;
            layoutPanel = mainFlowLayoutPanel;

            this.mainForm = mainForm;
            mainForm.PasswordsUpdate += UpdateForm;
            SetStatistics(statistics);

            LabelControllers = new List<IUpdatable>();
            Init();
        }

        protected virtual void Init()
        {
            InitChart();
            InitLabelsGroupBox();
            UpdateForm();
        }
        protected virtual void InitChart()
        {

        }
        protected virtual void InitLabelsGroupBox()
        {

        }

        public void UpdateForm()
        {
            UpdateChart();
            UpdateLablesGroupBox();
        }

        protected abstract void UpdateChart();
        //{
        //    T[] xValues;
        //    double[] yValues;
        //    getData<T>(out xValues, out yValues);
        //    UpdateChartByData<T>(yValues, xValues);
        //    //dataSenderFunc<T> dataSenderFunc = dataSenderFunc<T>(out xValues, out yValues);

        //}

        //protected abstract void getData<T>(out T[] xValues, out double[] yValues);

        //{
        //protected virtual void getData<T>(out T[] xValues, out double[] yValues)
        //{
        //    xValues = new T[0];
        //    yValues = new double[0];
        //}

        public void UpdateChartByData<T>(double[] yValues, T[] xValues)
        {
            LastSeries.Points.Clear();
            //if (xValues.Equals(null) || xValues.Length == 0)
            //{
            //    UpdateChartByData(yValues);
            //    return;
            //}
            for (int i = 0; i < yValues.Length; i++)
            {
                LastSeries.Points.AddXY(FormatX(xValues[i]), FormatY(yValues[i]));
            }
        }

        protected void UpdateChartByData(double[] yValues)
        {
            LastSeries.Points.Clear();
            for (int i = 0; i < yValues.Length; i++)
            {
                LastSeries.Points.AddY(FormatY(yValues[i]));
            }
        }

        protected virtual double FormatY(double value)
        {
            //return TimeSpanConverter.TotalSeconds(value);
            return value;
        }
        protected virtual T FormatX<T>(T value)
        {
            return value;
        }

        protected virtual void UpdateLablesGroupBox()
        {
            foreach (IUpdatable labelController in LabelControllers)
            {
                labelController.Update();
            }
        }

        protected void ChartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.PasswordsUpdate -= UpdateForm;
        }
    }
}
