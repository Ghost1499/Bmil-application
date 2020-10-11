﻿using System;
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
            Init();
        }

        private void Init()
        {
            InitTypingDinamicLine();
        }
        public void Update()
        {
            UpdateTypingDinamicLine();
            overlaysCountLabel.Text = mainForm.PasswordAction.OverlaysCount.ToString();
        }
        private void InitTypingDinamicLine()
        {
            Update();
        }
        public void UpdateTypingDinamicLine()
        {
            string[] typedSymbols;
            UpdateTypingDinamicLineFromData(mainForm.StatisticsManager.GetTypingDinamic(mainForm.PasswordAction, out typedSymbols), typedSymbols);
        }
        public void UpdateTypingDinamicLineFromData(double[] symbolsDinamic, string[] typedSymbols)
        {
            typingDinamicChart.Series.Last().Points.Clear();
            for (int i = 0; i < symbolsDinamic.Length; i++)
            {
                typingDinamicChart.Series.Last().Points.AddXY(typedSymbols[i],TimeSpanConverter.TotalSeconds(symbolsDinamic[i]));
            }
        }
    }
}