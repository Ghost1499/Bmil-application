namespace Task1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.histogramChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.acceptPasswordButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.typingDinamicChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.histogramChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typingDinamicChart)).BeginInit();
            this.SuspendLayout();
            // 
            // histogramChart
            // 
            chartArea1.Name = "ChartArea1";
            this.histogramChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.histogramChart.Legends.Add(legend1);
            this.histogramChart.Location = new System.Drawing.Point(564, 12);
            this.histogramChart.Name = "histogramChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.histogramChart.Series.Add(series1);
            this.histogramChart.Size = new System.Drawing.Size(557, 484);
            this.histogramChart.TabIndex = 0;
            this.histogramChart.Text = "Гистограмма скорости ввода парольной фразы";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Гистограмма скорости ввода парольной фразы";
            this.histogramChart.Titles.Add(title1);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(12, 56);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(326, 48);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            this.passwordTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyUp);
            // 
            // acceptPasswordButton
            // 
            this.acceptPasswordButton.Location = new System.Drawing.Point(427, 56);
            this.acceptPasswordButton.Name = "acceptPasswordButton";
            this.acceptPasswordButton.Size = new System.Drawing.Size(92, 48);
            this.acceptPasswordButton.TabIndex = 2;
            this.acceptPasswordButton.Text = "Принять";
            this.acceptPasswordButton.UseVisualStyleBackColor = true;
            this.acceptPasswordButton.Click += new System.EventHandler(this.acceptPasswordButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // typingDinamicChart
            // 
            chartArea2.Name = "ChartArea1";
            this.typingDinamicChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.typingDinamicChart.Legends.Add(legend2);
            this.typingDinamicChart.Location = new System.Drawing.Point(22, 284);
            this.typingDinamicChart.Name = "typingDinamicChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.typingDinamicChart.Series.Add(series2);
            this.typingDinamicChart.Size = new System.Drawing.Size(497, 300);
            this.typingDinamicChart.TabIndex = 5;
            this.typingDinamicChart.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "Title1";
            title2.Text = "График динамики ввода парольной фразы";
            this.typingDinamicChart.Titles.Add(title2);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 578);
            this.Controls.Add(this.typingDinamicChart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.acceptPasswordButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.histogramChart);
            this.Name = "MainForm";
            this.Text = "Task1";
            ((System.ComponentModel.ISupportInitialize)(this.histogramChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typingDinamicChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart histogramChart;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button acceptPasswordButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart typingDinamicChart;
    }
}

