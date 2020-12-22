using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task1.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Task1.Containers;
using System.Data.Entity;
using Task1.Statistics;

namespace Task1
{
    public partial class PasswordsVelocityChartForm : ChartForm
    {

        private TimeSpan? eveninigTime;
        private TimeSpan? morningTime;
        private PasswordActionContext daytimePasswords;
        private PasswordActionContext eveningtimePasswords;
        protected VelocityStatistics DaytimeStatistics { get; set; }
        protected VelocityStatistics EveningtimeStatistics { get; set; }
        private int CurrentUserId { get { return mainForm.AuthenticationController.CurrentUserId; } }

        private Series DaytimePasswordsSeries { get; set; }
        private Series EveningtimePasswordsSeries { get; set; }

        public PasswordsVelocityChartForm(MainForm mainForm):base(mainForm)
        {
            InitializeComponent();
        }
        ~PasswordsVelocityChartForm()
        {
            disposeContexts();
        }

        private void disposeContexts()
        {
            daytimePasswords.Dispose();
            eveningtimePasswords.Dispose();
        }

        protected override void Init()
        {
            eveninigTime = new TimeSpan(18, 0, 0);
            morningTime = new TimeSpan(6, 0, 0);
            daytimePasswords = new PasswordActionContext();
            eveningtimePasswords = new PasswordActionContext();
            LoadData();

            DaytimeStatistics = new VelocityStatistics(daytimePasswords.PasswordActions.Local);
            EveningtimeStatistics = new VelocityStatistics(eveningtimePasswords.PasswordActions.Local);
            base.Init();
        }

        protected override void LoadData()
        {
            daytimePasswords.PasswordActions
                .Include(p => p.SymbolActions)
                .Where(p => p.UserId == CurrentUserId)
                .Where(p => p.ValidPassword == Settings.Password)
                .Where(p => DbFunctions.CreateTime(p.StartTime.Hour, p.StartTime.Minute, p.StartTime.Second)
                < DbFunctions.CreateTime(eveninigTime.Value.Hours, eveninigTime.Value.Minutes, eveninigTime.Value.Seconds)
                && DbFunctions.CreateTime(p.StartTime.Hour, p.StartTime.Minute, p.StartTime.Second)
                >= DbFunctions.CreateTime(morningTime.Value.Hours, morningTime.Value.Minutes, morningTime.Value.Seconds))
                .Load();

            eveningtimePasswords.PasswordActions
                .Include(p => p.SymbolActions)
                .Where(p => p.UserId == CurrentUserId)
                .Where(p => p.ValidPassword == Settings.Password)
                .Where(p => DbFunctions.CreateTime(p.StartTime.Hour, p.StartTime.Minute, p.StartTime.Second)
                >= DbFunctions.CreateTime(eveninigTime.Value.Hours, eveninigTime.Value.Minutes, eveninigTime.Value.Seconds)
                || DbFunctions.CreateTime(p.StartTime.Hour, p.StartTime.Minute, p.StartTime.Second)
                < DbFunctions.CreateTime(morningTime.Value.Hours, morningTime.Value.Minutes, morningTime.Value.Seconds))
                .Load();
            //MessageBox.Show(daytimePasswords.PasswordActions.Local.Count.ToString() + " " + eveningtimePasswords.PasswordActions.Local.Count.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        protected override void InitChart()
        {
            base.InitChart();
            chart.Titles[0].Text = "Скорость набора парольной фразы ";
            mainChart.ChartAreas.Last().AxisY.Title = "символов в секунду";

            //chart.Series.Last().Points.DataBindY(daytimePasswords.PasswordActions.Local, "TimeDuration");
            chart.Series.Last().ChartType = SeriesChartType.Column;
            DaytimePasswordsSeries = chart.Series.Last();

            chart.Series.Add(new Series("Вечером"));
            chart.Series.Last().ChartType = SeriesChartType.Column;
            //chart.Series.Last().Points.DataBindY(eveningtimePasswords.PasswordActions.Local,"TimeDuration");
            EveningtimePasswordsSeries = chart.Series.Last();

            //UpdateChart();

        }

        protected override void InitLabelsGroupBox()
        {
            base.InitLabelsGroupBox();
            Control parent = layoutPanel;
            LabelElements.Add(new LabelElement("Днем Математическое ожидание", DaytimeStatistics.GetMathExpectation, layoutPanel));
            LabelElements.Add(new LabelElement("Вечером Математическое ожидание", EveningtimeStatistics.GetMathExpectation, layoutPanel));
            LabelElements.Add(new LabelElement("Днем Дисперсия", DaytimeStatistics.GetDispersion, layoutPanel));
            LabelElements.Add(new LabelElement("Вечером Дисперсия", EveningtimeStatistics.GetDispersion, layoutPanel));
            LabelElements.Add(new LabelElement("Днем Среднеквадратическое отклонение", DaytimeStatistics.GetSigma, layoutPanel));
            LabelElements.Add(new LabelElement("Вечером Среднеквадратическое отклонение", EveningtimeStatistics.GetSigma, layoutPanel));

        }


        protected override void UpdateChart()
        {
            DaytimePasswordsSeries.Points.DataBindY(DaytimeStatistics/*daytimePasswords.PasswordActions.Local, "TimeDuration"*/);
            EveningtimePasswordsSeries.Points.DataBindY(EveningtimeStatistics/*eveningtimePasswords.PasswordActions.Local, "TimeDuration"*/);

        }

        protected override void ReloadData()
        {
            daytimePasswords = new PasswordActionContext();
            eveningtimePasswords = new PasswordActionContext();
            LoadData();

            DaytimeStatistics.ChangeCollection(daytimePasswords.PasswordActions.Local);
            EveningtimeStatistics.ChangeCollection(eveningtimePasswords.PasswordActions.Local);

            UpdateChart();
            UpdateLablesGroupBox();
        }

    }
}
