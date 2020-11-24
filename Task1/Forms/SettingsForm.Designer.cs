namespace Task1.Forms
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordSampleTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.acceptPasswordSampleButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.newUserTextBox = new System.Windows.Forms.TextBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пароль для проведения тестов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Алфавит пароля";
            // 
            // passwordSampleTextBox
            // 
            this.passwordSampleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordSampleTextBox.Location = new System.Drawing.Point(30, 102);
            this.passwordSampleTextBox.Name = "passwordSampleTextBox";
            this.passwordSampleTextBox.Size = new System.Drawing.Size(222, 44);
            this.passwordSampleTextBox.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(30, 260);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 3;
            // 
            // acceptPasswordSampleButton
            // 
            this.acceptPasswordSampleButton.Location = new System.Drawing.Point(330, 102);
            this.acceptPasswordSampleButton.Name = "acceptPasswordSampleButton";
            this.acceptPasswordSampleButton.Size = new System.Drawing.Size(112, 44);
            this.acceptPasswordSampleButton.TabIndex = 4;
            this.acceptPasswordSampleButton.Text = "Принять";
            this.acceptPasswordSampleButton.UseVisualStyleBackColor = true;
            this.acceptPasswordSampleButton.Click += new System.EventHandler(this.acceptPasswordSampleButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(277, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Добавить пользователя";
            // 
            // newUserTextBox
            // 
            this.newUserTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newUserTextBox.Location = new System.Drawing.Point(330, 279);
            this.newUserTextBox.Name = "newUserTextBox";
            this.newUserTextBox.Size = new System.Drawing.Size(222, 44);
            this.newUserTextBox.TabIndex = 6;
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(377, 339);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(112, 44);
            this.addUserButton.TabIndex = 7;
            this.addUserButton.Text = "Добавить";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.newUserTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.acceptPasswordSampleButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.passwordSampleTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordSampleTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button acceptPasswordSampleButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newUserTextBox;
        private System.Windows.Forms.Button addUserButton;
    }
}