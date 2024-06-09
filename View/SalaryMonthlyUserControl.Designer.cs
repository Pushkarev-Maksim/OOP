using System.Windows.Forms;
using View.Properties;

namespace View
{
    partial class SalaryMonthlyUserControl
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
            this.labelFixedSalary = new System.Windows.Forms.Label();
            this.labelMonthlyWorkingDays = new System.Windows.Forms.Label();
            this.labelActualWorkedDays = new System.Windows.Forms.Label();
            this.textBoxFixedSalary = new System.Windows.Forms.TextBox();
            this.textBoxMonthlyWorkingDays = new System.Windows.Forms.TextBox();
            this.textBoxActualWorkedDays = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelFixedSalary
            // 
            this.labelFixedSalary.AutoSize = true;
            this.labelFixedSalary.Location = new System.Drawing.Point(10, 14);
            this.labelFixedSalary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFixedSalary.Name = "labelFixedSalary";
            this.labelFixedSalary.Size = new System.Drawing.Size(130, 13);
            this.labelFixedSalary.TabIndex = 1;
            this.labelFixedSalary.Text = "Оклад за полный месяц";
            // 
            // labelMonthlyWorkingDays
            // 
            this.labelMonthlyWorkingDays.AutoSize = true;
            this.labelMonthlyWorkingDays.Location = new System.Drawing.Point(10, 34);
            this.labelMonthlyWorkingDays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMonthlyWorkingDays.Name = "labelMonthlyWorkingDays";
            this.labelMonthlyWorkingDays.Size = new System.Drawing.Size(161, 13);
            this.labelMonthlyWorkingDays.TabIndex = 2;
            this.labelMonthlyWorkingDays.Text = "Кол-во рабочих дней в месяце";
            // 
            // labelActualWorkedDays
            // 
            this.labelActualWorkedDays.AutoSize = true;
            this.labelActualWorkedDays.Location = new System.Drawing.Point(10, 57);
            this.labelActualWorkedDays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelActualWorkedDays.Name = "labelActualWorkedDays";
            this.labelActualWorkedDays.Size = new System.Drawing.Size(142, 13);
            this.labelActualWorkedDays.TabIndex = 3;
            this.labelActualWorkedDays.Text = "Кол-во отработанных дней";
            // 
            // textBoxFixedSalary
            // 
            this.textBoxFixedSalary.Location = new System.Drawing.Point(144, 12);
            this.textBoxFixedSalary.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFixedSalary.Name = "textBoxFixedSalary";
            this.textBoxFixedSalary.Size = new System.Drawing.Size(161, 20);
            this.textBoxFixedSalary.TabIndex = 0;
            // 
            // textBoxMonthlyWorkingDays
            // 
            this.textBoxMonthlyWorkingDays.Location = new System.Drawing.Point(275, 34);
            this.textBoxMonthlyWorkingDays.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMonthlyWorkingDays.Name = "textBoxMonthlyWorkingDays";
            this.textBoxMonthlyWorkingDays.Size = new System.Drawing.Size(30, 20);
            this.textBoxMonthlyWorkingDays.TabIndex = 4;
            // 
            // textBoxActualWorkedDays
            // 
            this.textBoxActualWorkedDays.Location = new System.Drawing.Point(275, 57);
            this.textBoxActualWorkedDays.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxActualWorkedDays.Name = "textBoxActualWorkedDays";
            this.textBoxActualWorkedDays.Size = new System.Drawing.Size(30, 20);
            this.textBoxActualWorkedDays.TabIndex = 5;
            // 
            // SalaryMonthlyUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 82);
            this.Controls.Add(this.labelFixedSalary);
            this.Controls.Add(this.labelMonthlyWorkingDays);
            this.Controls.Add(this.labelActualWorkedDays);
            this.Controls.Add(this.textBoxFixedSalary);
            this.Controls.Add(this.textBoxMonthlyWorkingDays);
            this.Controls.Add(this.textBoxActualWorkedDays);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SalaryMonthlyUserControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelFixedSalary;
        private Label labelMonthlyWorkingDays;
        private Label labelActualWorkedDays;
        private TextBox textBoxFixedSalary;
        private TextBox textBoxMonthlyWorkingDays;
        private TextBox textBoxActualWorkedDays;
    }
}