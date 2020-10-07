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
    public partial class PasswordDinamicForm : Form
    {
        MainForm mainForm;
        public PasswordDinamicForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            InitTypingDinamicLine();
        }

        private void InitTypingDinamicLine()
        {
            UpdateTypingDinamicLine();
        }
        public void UpdateTypingDinamicLine()
        {
            string[] typedSymbols;
            UpdateTypingDinamicLineFromData(mainForm.StatisticsManager.GetTypingDinamic(mainForm.PasswordActions.Last(), out typedSymbols), typedSymbols);
        }
        public void UpdateTypingDinamicLineFromData(long[] symbolsDinamic, string[] typedSymbols)
        {
            typingDinamicChart.Series.Last().Points.Clear();
            for (int i = 0; i < symbolsDinamic.Length; i++)
            {
                typingDinamicChart.Series.Last().Points.AddXY(typedSymbols[i],TimeSpan.FromMilliseconds(symbolsDinamic[i]).TotalSeconds);
            }
        }
    }
}
