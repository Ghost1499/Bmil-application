namespace Task1.Forms
{
    partial class PressDurationChartForm
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
            this.pressDurationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sigmaLabel = new System.Windows.Forms.Label();
            this.dispersionLabel = new System.Windows.Forms.Label();
            this.mathExpectationLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pressDurationChart)).BeginInit();
            this.SuspendLayout();
            // 
            // pressDurationChart
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisY.Title = "секунд";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.Name = "ChartArea1";
            this.pressDurationChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.pressDurationChart.Legends.Add(legend1);
            this.pressDurationChart.Location = new System.Drawing.Point(12, 12);
            this.pressDurationChart.Name = "pressDurationChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.pressDurationChart.Series.Add(series1);
            this.pressDurationChart.Size = new System.Drawing.Size(866, 528);
            this.pressDurationChart.TabIndex = 7;
            this.pressDurationChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "График длительности нажатия клавиш";
            this.pressDurationChart.Titles.Add(title1);
            // 
            // sigmaLabel
            // 
            this.sigmaLabel.AutoSize = true;
            this.sigmaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sigmaLabel.Location = new System.Drawing.Point(1015, 341);
            this.sigmaLabel.Name = "sigmaLabel";
            this.sigmaLabel.Size = new System.Drawing.Size(94, 37);
            this.sigmaLabel.TabIndex = 25;
            this.sigmaLabel.Text = "None";
            // 
            // dispersionLabel
            // 
            this.dispersionLabel.AutoSize = true;
            this.dispersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dispersionLabel.Location = new System.Drawing.Point(1015, 203);
            this.dispersionLabel.Name = "dispersionLabel";
            this.dispersionLabel.Size = new System.Drawing.Size(94, 37);
            this.dispersionLabel.TabIndex = 24;
            this.dispersionLabel.Text = "None";
            // 
            // mathExpectationLabel
            // 
            this.mathExpectationLabel.AutoSize = true;
            this.mathExpectationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mathExpectationLabel.Location = new System.Drawing.Point(1015, 77);
            this.mathExpectationLabel.Name = "mathExpectationLabel";
            this.mathExpectationLabel.Size = new System.Drawing.Size(94, 37);
            this.mathExpectationLabel.TabIndex = 23;
            this.mathExpectationLabel.Text = "None";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(907, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(526, 37);
            this.label7.TabIndex = 22;
            this.label7.Text = "Среднеквадратическое отклонение";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(907, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(417, 37);
            this.label6.TabIndex = 21;
            this.label6.Text = "Дисперсия в миллисекундах";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(907, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(409, 37);
            this.label5.TabIndex = 20;
            this.label5.Text = "Математическое ожидание";
            // 
            // PressDurationChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 556);
            this.Controls.Add(this.sigmaLabel);
            this.Controls.Add(this.dispersionLabel);
            this.Controls.Add(this.mathExpectationLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pressDurationChart);
            this.Name = "PressDurationChartForm";
            this.Text = "PressDurationChartForm";
            ((System.ComponentModel.ISupportInitialize)(this.pressDurationChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart pressDurationChart;
        private System.Windows.Forms.Label sigmaLabel;
        private System.Windows.Forms.Label dispersionLabel;
        private System.Windows.Forms.Label mathExpectationLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}