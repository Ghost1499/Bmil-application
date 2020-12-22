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
using Task1.Statistics;

namespace Task1.Forms
{
    public partial class TypingDinamicChartForm : ChartForm
    {

        private PasswordActionContext context;
        protected TypingDinamicStatistics Statistics { get; set; }
        private int CurrentUserId { get { return Settings.UserId; } }

        private int PasswordActionId { get; set; }

        private Series KeyPressSeries { get; set; }

        public TypingDinamicChartForm(MainForm mainForm) : base(mainForm)
        {
            InitializeComponent();

        }
        ~TypingDinamicChartForm()
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

            Statistics = new TypingDinamicStatistics(context.SymbolActions.Local);
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
            chart.Titles[0].Text = "Длительность нажатия клавиш ";
            mainChart.ChartAreas.Last().AxisY.Title = "миллисекунд";

            //chart.Series.Last().Points.DataBindY(daytimePasswords.PasswordActions.Local, "TimeDuration");
            chart.Series.Last().ChartType = SeriesChartType.Line;
            KeyPressSeries = chart.Series.Last();



        }

        protected override void InitLabelsGroupBox()
        {
            base.InitLabelsGroupBox();
            Control parent = layoutPanel;
            PasswordAction passwordAction = context.PasswordActions.Local.Last();
            LabelElements.Add(new LabelElement("Математическое ожидание", Statistics.GetMathExpectation, layoutPanel));
            LabelElements.Add(new LabelElement("Дисперсия", Statistics.GetDispersion, layoutPanel));
            LabelElements.Add(new LabelElement("Среднеквадратическое отклонение", Statistics.GetSigma, layoutPanel));
            LabelElements.Add(new LabelElement("Количество наложений", GetOverlaysCount, layoutPanel));


        }


        protected override void UpdateChart()
        {
            PasswordAction passwordAction = context.PasswordActions.Local.Last();
            KeyPressSeries.Points.DataBindXY(passwordAction.GetTypedSymbols(), Statistics);
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

            Statistics.ChangeCollection(context.SymbolActions.Local);

            UpdateChart();
            UpdateLablesGroupBox();
        }

        private double GetOverlaysCount()
        {
            return context.PasswordActions.Local.Last().OverlaysCount;
        }
    }
}
