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
            this.passwordsDurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typingDimanicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordKeyPressDurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordsVelocityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordComplexetyLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mainMenuStrip.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(12, 103);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(326, 48);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            this.passwordTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyUp);
            // 
            // acceptPasswordButton
            // 
            this.acceptPasswordButton.Location = new System.Drawing.Point(388, 103);
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
            this.samplePasswordLabel.Location = new System.Drawing.Point(12, 45);
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
            this.passwordsDurationToolStripMenuItem,
            this.typingDimanicToolStripMenuItem,
            this.passwordKeyPressDurationToolStripMenuItem,
            this.passwordsVelocityToolStripMenuItem,
            this.functionToolStripMenuItem});
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
            // passwordsVelocityToolStripMenuItem
            // 
            this.passwordsVelocityToolStripMenuItem.Name = "passwordsVelocityToolStripMenuItem";
            this.passwordsVelocityToolStripMenuItem.Size = new System.Drawing.Size(344, 30);
            this.passwordsVelocityToolStripMenuItem.Text = "Скорость ввода паролей";
            this.passwordsVelocityToolStripMenuItem.Click += new System.EventHandler(this.passwordsVelocityToolStripMenuItem_Click);
            // 
            // functionToolStripMenuItem
            // 
            this.functionToolStripMenuItem.Name = "functionToolStripMenuItem";
            this.functionToolStripMenuItem.Size = new System.Drawing.Size(344, 30);
            this.functionToolStripMenuItem.Text = "Функция f(x)";
            this.functionToolStripMenuItem.Click += new System.EventHandler(this.functionToolStripMenuItem_Click);
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
            this.passwordComplexetyLabel.Location = new System.Drawing.Point(386, 288);
            this.passwordComplexetyLabel.Name = "passwordComplexetyLabel";
            this.passwordComplexetyLabel.Size = new System.Drawing.Size(94, 37);
            this.passwordComplexetyLabel.TabIndex = 10;
            this.passwordComplexetyLabel.Text = "None";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "Сложность пароля";
            // 
            // usersListBox
            // 
            this.usersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.ItemHeight = 26;
            this.usersListBox.Location = new System.Drawing.Point(690, 74);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(291, 186);
            this.usersListBox.TabIndex = 18;
            this.usersListBox.SelectedIndexChanged += new System.EventHandler(this.usersListBox_SelectedIndexChanged);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(690, 287);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(212, 48);
            this.deleteUserButton.TabIndex = 19;
            this.deleteUserButton.Text = "Удалить пользователя";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(164, 29);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ввод паролей";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(173, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(192, 29);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.Text = "Идентификация";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(371, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(166, 29);
            this.radioButton3.TabIndex = 22;
            this.radioButton3.Text = "Верификация";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radioButton1);
            this.flowLayoutPanel1.Controls.Add(this.radioButton2);
            this.flowLayoutPanel1.Controls.Add(this.radioButton3);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 157);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(628, 51);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 605);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.usersListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordComplexetyLabel);
            this.Controls.Add(this.samplePasswordLabel);
            this.Controls.Add(this.acceptPasswordButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа для сбора биометрических данных ввода пароля";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordsDurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typingDimanicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordKeyPressDurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordsVelocityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem;
        private System.Windows.Forms.ListBox usersListBox;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

