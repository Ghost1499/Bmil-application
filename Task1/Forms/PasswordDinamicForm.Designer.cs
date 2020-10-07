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
            ((System.ComponentModel.ISupportInitialize)(this.typingDinamicChart)).BeginInit();
            this.SuspendLayout();
            // 
            // typingDinamicChart
            // 
            chartArea1.Name = "ChartArea1";
            this.typingDinamicChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.typingDinamicChart.Legends.Add(legend1);
            this.typingDinamicChart.Location = new System.Drawing.Point(34, 26);
            this.typingDinamicChart.Name = "typingDinamicChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.typingDinamicChart.Series.Add(series1);
            this.typingDinamicChart.Size = new System.Drawing.Size(1179, 485);
            this.typingDinamicChart.TabIndex = 6;
            this.typingDinamicChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "График динамики ввода парольной фразы";
            this.typingDinamicChart.Titles.Add(title1);
            // 
            // PasswordDinamicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 587);
            this.Controls.Add(this.typingDinamicChart);
            this.Name = "PasswordDinamicForm";
            this.Text = "PasswordDinamicForm";
            ((System.ComponentModel.ISupportInitialize)(this.typingDinamicChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart typingDinamicChart;
    }
}