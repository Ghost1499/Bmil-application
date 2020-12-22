namespace Task1.Forms
{
    partial class UserForm
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
            this.components = new System.ComponentModel.Container();
            this.passwordActionsGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overlaysCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordActionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.passwordActionsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordActionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordActionsGridView
            // 
            this.passwordActionsGridView.AllowUserToAddRows = false;
            this.passwordActionsGridView.AllowUserToDeleteRows = false;
            this.passwordActionsGridView.AllowUserToOrderColumns = true;
            this.passwordActionsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordActionsGridView.AutoGenerateColumns = false;
            this.passwordActionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passwordActionsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.validPasswordDataGridViewTextBoxColumn,
            this.timeDurationDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.overlaysCountDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn});
            this.passwordActionsGridView.DataSource = this.passwordActionBindingSource;
            this.passwordActionsGridView.Location = new System.Drawing.Point(308, 12);
            this.passwordActionsGridView.Name = "passwordActionsGridView";
            this.passwordActionsGridView.RowTemplate.Height = 28;
            this.passwordActionsGridView.Size = new System.Drawing.Size(956, 507);
            this.passwordActionsGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // validPasswordDataGridViewTextBoxColumn
            // 
            this.validPasswordDataGridViewTextBoxColumn.DataPropertyName = "ValidPassword";
            this.validPasswordDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.validPasswordDataGridViewTextBoxColumn.Name = "validPasswordDataGridViewTextBoxColumn";
            // 
            // timeDurationDataGridViewTextBoxColumn
            // 
            this.timeDurationDataGridViewTextBoxColumn.DataPropertyName = "TimeDuration";
            this.timeDurationDataGridViewTextBoxColumn.HeaderText = "Длительность ввода";
            this.timeDurationDataGridViewTextBoxColumn.Name = "timeDurationDataGridViewTextBoxColumn";
            this.timeDurationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "Время начала ввода";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            // 
            // overlaysCountDataGridViewTextBoxColumn
            // 
            this.overlaysCountDataGridViewTextBoxColumn.DataPropertyName = "OverlaysCount";
            this.overlaysCountDataGridViewTextBoxColumn.HeaderText = "Количество наложений";
            this.overlaysCountDataGridViewTextBoxColumn.Name = "overlaysCountDataGridViewTextBoxColumn";
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "Время  окончания ввода";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            // 
            // passwordActionBindingSource
            // 
            this.passwordActionBindingSource.DataSource = typeof(Task1.PasswordAction);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(57, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Информация";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.idLabel.Location = new System.Drawing.Point(150, 70);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(48, 25);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "Нет";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.loginLabel.Location = new System.Drawing.Point(150, 136);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(48, 25);
            this.loginLabel.TabIndex = 5;
            this.loginLabel.Text = "Нет";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 531);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordActionsGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name = "UserForm";
            this.Text = "Информация о пользователе";
            ((System.ComponentModel.ISupportInitialize)(this.passwordActionsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordActionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView passwordActionsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn overlaysCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource passwordActionBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label loginLabel;
    }
}