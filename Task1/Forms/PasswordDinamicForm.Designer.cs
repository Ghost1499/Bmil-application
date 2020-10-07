namespace Task1.Forms
{
    partial class PasswordDinamicForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.typingDinamicChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.overlaysCountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.typingDinamicChart)).BeginInit();
            this.SuspendLayout();
            // 
            // typingDinamicChart
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisY.Title = "секунд";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.Name = "ChartArea1";
            this.typingDinamicChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.typingDinamicChart.Legends.Add(legend1);
            this.typingDinamicChart.Location = new System.Drawing.Point(34, 26);
            this.typingDinamicChart.Name = "typingDinamicChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.typingDinamicChart.Series.Add(series1);
            this.typingDinamicChart.Size = new System.Drawing.Size(925, 528);
            this.typingDinamicChart.TabIndex = 6;
            this.typingDinamicChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "График динамики ввода парольной фразы";
            this.typingDinamicChart.Titles.Add(title1);
            // 
            // overlaysCountLabel
            // 
            this.overlaysCountLabel.AutoSize = true;
            this.overlaysCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.overlaysCountLabel.Location = new System.Drawing.Point(1054, 59);
            this.overlaysCountLabel.Name = "overlaysCountLabel";
            this.overlaysCountLabel.Size = new System.Drawing.Size(100, 37);
            this.overlaysCountLabel.TabIndex = 7;
            this.overlaysCountLabel.Text = "label1";
            // 
            // PasswordDinamicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 587);
            this.Controls.Add(this.overlaysCountLabel);
            this.Controls.Add(this.typingDinamicChart);
            this.Name = "PasswordDinamicForm";
            this.Text = "PasswordDinamicForm";
            ((System.ComponentModel.ISupportInitialize)(this.typingDinamicChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart typingDinamicChart;
        private System.Windows.Forms.Label overlaysCountLabel;
    }
}