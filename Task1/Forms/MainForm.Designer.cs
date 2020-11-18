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
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.acceptPasswordButton = new System.Windows.Forms.Button();
            this.samplePasswordLabel = new System.Windows.Forms.Label();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
<<<<<<< HEAD
            this.passwordsDurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typingDimanicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordKeyPressDurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
=======
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordDinamicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyPressDurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
>>>>>>> 9680844b32b96d6de35f6916d7f3ebb952050b53
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordComplexetyLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mathExpectationLabel = new System.Windows.Forms.Label();
            this.dispersionLabel = new System.Windows.Forms.Label();
            this.sigmaLabel = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.passwordsVelocityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
=======
            this.passwordsDurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
>>>>>>> 9680844b32b96d6de35f6916d7f3ebb952050b53
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(22, 103);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(326, 48);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            this.passwordTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyUp);
            // 
            // acceptPasswordButton
            // 
            this.acceptPasswordButton.Location = new System.Drawing.Point(464, 103);
            this.acceptPasswordButton.Name = "acceptPasswordButton";
            this.acceptPasswordButton.Size = new System.Drawing.Size(92, 48);
            this.acceptPasswordButton.TabIndex = 2;
            this.acceptPasswordButton.Text = "Принять";
            this.acceptPasswordButton.UseVisualStyleBackColor = true;
            this.acceptPasswordButton.Click += new System.EventHandler(this.acceptPasswordButton_Click);
            // 
            // samplePasswordLabel
            // 
            this.samplePasswordLabel.AutoSize = true;
            this.samplePasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.samplePasswordLabel.Location = new System.Drawing.Point(200, 41);
            this.samplePasswordLabel.Name = "samplePasswordLabel";
            this.samplePasswordLabel.Size = new System.Drawing.Size(102, 37);
            this.samplePasswordLabel.TabIndex = 6;
            this.samplePasswordLabel.Text = "label3";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.статистикаToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1133, 33);
            this.mainMenuStrip.TabIndex = 7;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
<<<<<<< HEAD
            this.passwordsDurationToolStripMenuItem,
            this.typingDimanicToolStripMenuItem,
            this.passwordKeyPressDurationToolStripMenuItem,
            this.passwordsVelocityToolStripMenuItem});
=======
            this.histogramToolStripMenuItem,
            this.passwordDinamicToolStripMenuItem,
            this.keyPressDurationToolStripMenuItem,
            this.passwordsDurationToolStripMenuItem});
>>>>>>> 9680844b32b96d6de35f6916d7f3ebb952050b53
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            // 
            // passwordsDurationToolStripMenuItem
            // 
            this.passwordsDurationToolStripMenuItem.Name = "passwordsDurationToolStripMenuItem";
            this.passwordsDurationToolStripMenuItem.Size = new System.Drawing.Size(344, 30);
            this.passwordsDurationToolStripMenuItem.Text = "Статистика вводов";
            this.passwordsDurationToolStripMenuItem.Click += new System.EventHandler(this.passwordsDurationToolStripMenuItem_Click);
            // 
            // typingDimanicToolStripMenuItem
            // 
            this.typingDimanicToolStripMenuItem.Name = "typingDimanicToolStripMenuItem";
            this.typingDimanicToolStripMenuItem.Size = new System.Drawing.Size(344, 30);
            this.typingDimanicToolStripMenuItem.Text = "Динамика ввода";
            this.typingDimanicToolStripMenuItem.Click += new System.EventHandler(this.typingDimanicToolStripMenuItem_Click);
            // 
            // passwordKeyPressDurationToolStripMenuItem
            // 
            this.passwordKeyPressDurationToolStripMenuItem.Name = "passwordKeyPressDurationToolStripMenuItem";
            this.passwordKeyPressDurationToolStripMenuItem.Size = new System.Drawing.Size(344, 30);
            this.passwordKeyPressDurationToolStripMenuItem.Text = "Длительность нажатия клавиш";
            this.passwordKeyPressDurationToolStripMenuItem.Click += new System.EventHandler(this.passwordKeyPressDurationToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.settingsToolStripMenuItem.Text = "Параметры";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // keyPressDurationToolStripMenuItem
            // 
            this.keyPressDurationToolStripMenuItem.Name = "keyPressDurationToolStripMenuItem";
            this.keyPressDurationToolStripMenuItem.Size = new System.Drawing.Size(344, 30);
            this.keyPressDurationToolStripMenuItem.Text = "Длительность нажатия клавиш";
            this.keyPressDurationToolStripMenuItem.Click += new System.EventHandler(this.keyPressDurationToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.settingsToolStripMenuItem.Text = "Параметры";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // passwordComplexetyLabel
            // 
            this.passwordComplexetyLabel.AutoSize = true;
            this.passwordComplexetyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordComplexetyLabel.Location = new System.Drawing.Point(586, 421);
            this.passwordComplexetyLabel.Name = "passwordComplexetyLabel";
            this.passwordComplexetyLabel.Size = new System.Drawing.Size(94, 37);
            this.passwordComplexetyLabel.TabIndex = 10;
            this.passwordComplexetyLabel.Text = "None";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(19, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "Сложность пароля";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(409, 37);
            this.label5.TabIndex = 12;
            this.label5.Text = "Математическое ожидание";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(15, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(417, 37);
            this.label6.TabIndex = 13;
            this.label6.Text = "Дисперсия в миллисекундах";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(15, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(526, 37);
            this.label7.TabIndex = 14;
            this.label7.Text = "Среднеквадратическое отклонение";
            // 
            // mathExpectationLabel
            // 
            this.mathExpectationLabel.AutoSize = true;
            this.mathExpectationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mathExpectationLabel.Location = new System.Drawing.Point(586, 223);
            this.mathExpectationLabel.Name = "mathExpectationLabel";
            this.mathExpectationLabel.Size = new System.Drawing.Size(94, 37);
            this.mathExpectationLabel.TabIndex = 15;
            this.mathExpectationLabel.Text = "None";
            // 
            // dispersionLabel
            // 
            this.dispersionLabel.AutoSize = true;
            this.dispersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dispersionLabel.Location = new System.Drawing.Point(586, 292);
            this.dispersionLabel.Name = "dispersionLabel";
            this.dispersionLabel.Size = new System.Drawing.Size(94, 37);
            this.dispersionLabel.TabIndex = 16;
            this.dispersionLabel.Text = "None";
            // 
            // sigmaLabel
            // 
            this.sigmaLabel.AutoSize = true;
            this.sigmaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sigmaLabel.Location = new System.Drawing.Point(586, 354);
            this.sigmaLabel.Name = "sigmaLabel";
            this.sigmaLabel.Size = new System.Drawing.Size(94, 37);
            this.sigmaLabel.TabIndex = 17;
            this.sigmaLabel.Text = "None";
            // 
<<<<<<< HEAD
            // passwordsVelocityToolStripMenuItem
            // 
            this.passwordsVelocityToolStripMenuItem.Name = "passwordsVelocityToolStripMenuItem";
            this.passwordsVelocityToolStripMenuItem.Size = new System.Drawing.Size(344, 30);
            this.passwordsVelocityToolStripMenuItem.Text = "Скорость ввода паролей";
            this.passwordsVelocityToolStripMenuItem.Click += new System.EventHandler(this.passwordsVelocityToolStripMenuItem_Click);
=======
            // passwordsDurationToolStripMenuItem
            // 
            this.passwordsDurationToolStripMenuItem.Name = "passwordsDurationToolStripMenuItem";
            this.passwordsDurationToolStripMenuItem.Size = new System.Drawing.Size(344, 30);
            this.passwordsDurationToolStripMenuItem.Text = "Длительность паролей";
            this.passwordsDurationToolStripMenuItem.Click += new System.EventHandler(this.passwordsDurationToolStripMenuItem_Click);
>>>>>>> 9680844b32b96d6de35f6916d7f3ebb952050b53
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 605);
            this.Controls.Add(this.sigmaLabel);
            this.Controls.Add(this.dispersionLabel);
            this.Controls.Add(this.mathExpectationLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordComplexetyLabel);
            this.Controls.Add(this.samplePasswordLabel);
            this.Controls.Add(this.acceptPasswordButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task1";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button acceptPasswordButton;
        private System.Windows.Forms.Label samplePasswordLabel;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.Label passwordComplexetyLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label mathExpectationLabel;
        private System.Windows.Forms.Label dispersionLabel;
        private System.Windows.Forms.Label sigmaLabel;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordsDurationToolStripMenuItem;
<<<<<<< HEAD
        private System.Windows.Forms.ToolStripMenuItem typingDimanicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordKeyPressDurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordsVelocityToolStripMenuItem;
=======
>>>>>>> 9680844b32b96d6de35f6916d7f3ebb952050b53
    }
}

