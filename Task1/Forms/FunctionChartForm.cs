using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Task1.Containers;

namespace Task1.Forms
{
    public partial class FunctionChartForm : ChartForm
    {

        private PasswordActionContext context;
        private int CurrentUserId { get { return Settings.UserId; } }

        private int? PasswordActionId { get; set; }

        private Series FunctionSeries { get; set; }

        private TextBox VectorTextBox { get; set; }

        private PasswordAction PasswordAction { get { return context.PasswordActions.Local.Last(); } }

        public FunctionChartForm(MainForm mainForm) : base(mainForm)
        {
            InitializeComponent();

        }
        ~FunctionChartForm()
        {
            disposeContexts();
        }

        private void disposeContexts()
        {
            context.Dispose();
        }

        protected override void Init()
        {
            mainForm.PasswordsUpdate -= UpdateForm;
            mainForm.PasswordsUpdate += ReloadData;

            context = new PasswordActionContext();

            GetLastPasswordActionId();
            LoadData();

            layoutPanel.Font = new Font(layoutPanel.Font.FontFamily, 12);
            VectorTextBox = new TextBox();
            VectorTextBox.Multiline = true;
            VectorTextBox.Width = layoutPanel.Width - 5;
            VectorTextBox.Height = layoutPanel.Height - 10;
            VectorTextBox.ReadOnly = true;
            //VectorTextBox.Dock= DockStyle.Fill;
            layoutPanel.Controls.Add(VectorTextBox);
            base.Init();
        }



        protected override void LoadData()
        {
            context.PasswordActions
                .Where(p => p.Id == PasswordActionId)
                .Include(p => p.SymbolActions)
                .Load();
        }
        protected override void InitChart()
        {
            base.InitChart();
            FunctionSeries = chart.Series.Last();
            chart.Titles[0].Text = "Функция f(x)";
            mainChart.ChartAreas.Last().AxisY.Title = "амплитуда";
            FunctionSeries.ChartType = SeriesChartType.StepLine;
            FunctionSeries.BorderWidth = 3;
            chart.ChartAreas[0].AxisY.Interval = 1;
            chart.ChartAreas[0].AxisY.Minimum = 0;
            chart.ChartAreas[0].AxisY.Maximum = 2;

            chart.ChartAreas[0].AxisX.Interval = 0.1;
            chart.ChartAreas[0].AxisX.Minimum = 0;
            chart.ChartAreas[0].AxisX.Maximum = 1;


        }

        protected override void InitLabelsGroupBox()
        {
            base.InitLabelsGroupBox();
            double[] vecor = PasswordAction.GetBiometricalVector();
            
            Control parent = layoutPanel;
            //LabelElements.Add(new LabelElement("Математическое ожидание", Statistics.GetMathExpectation, layoutPanel));
            //LabelElements.Add(new LabelElement("Дисперсия", Statistics.GetDispersion, layoutPanel));
            //LabelElements.Add(new LabelElement("Среднеквадратическое отклонение", Statistics.GetSigma, layoutPanel));
            //LabelElements.Add(new LabelElement("Количество наложений", GetOverlaysCount, layoutPanel));


        }

        protected override void UpdateForm()
        {
            base.UpdateForm();
            double[] vector = PasswordAction.GetBiometricalVector();
            VectorTextBox.Text = "";
            for (int i = 0; i < vector.Length; i++)
            {
                VectorTextBox.Text += i + ": " + vector[i]+"\r\n";
            }
            
        }

        protected override void UpdateChart()
        {
            SortedList<double, int> function = PasswordAction.NormalizedFunction();
            double[] yValues;
            yValues = Array.ConvertAll(function.Values.ToArray(), (val) => (double)val);
            FunctionSeries.Points.DataBindXY(function.Keys,yValues);
            //KeyPressSeries.Points.DataBindY(context.SymbolActions, "SymbolValue", context.SymbolActions,"KeyPressDuration");

        }

        private void GetLastPasswordActionId()
        {
            PasswordActionId = context.PasswordActions
                  .Where(p => p.UserId == Settings.UserId)
                  .ToList()
                  .LastOrDefault().Id;

        }
        protected override void ReloadData()
        {
            GetLastPasswordActionId();
            context = new PasswordActionContext();
            LoadData();


            UpdateForm();
            //UpdateLablesGroupBox();
        }

        private double GetOverlaysCount()
        {
            return context.PasswordActions.Local.Last().OverlaysCount;
        }
    }
    //public partial class FunctionChartForm : ChartForm
    //{

    //    double[] vector;
    //    public FunctionChartForm(MainForm mainForm) : base(mainForm)
    //    {
    //        InitializeComponent();
    //    }

       
    //    protected override void UpdateChart()
    //    {
    //        SortedList<double, int> function = mainForm.StatisticsManager.PasswordAction.NormalizedFunction();
    //        double[] yValues;
    //        yValues=Array.ConvertAll(function.Values.ToArray(),(val)=>(double)val);
    //        UpdateChartByData(yValues, function.Keys.Select((val) => Math.Round(val, 2)).ToArray());
    //    }

    //    protected override void InitLabelsGroupBox()
    //    {
    //        base.InitLabelsGroupBox();
    //        LabelsContainer container = LabelsContainer as LabelsContainer;
    //        vector = GetStatistics().GetPasswordVector();
    //        List<IUpdatable> labelElements = new List<IUpdatable>();
    //        for(int i = 0; i < vector.Length; i++)
    //        {
    //            int local_i = i;
    //            labelElements.Add(new LabelElement(local_i.ToString(), ()=>vector[local_i], layoutPanel));
    //        }
    //        ((LabelsContainer)LabelsContainer).AddChildren(labelElements);
    //    }
    //}
}
