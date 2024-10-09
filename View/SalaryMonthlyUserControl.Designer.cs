using System.Windows.Forms;

namespace View
{
    partial class SalaryMonthlyUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
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
            this.labelFixedSalary.Location = new System.Drawing.Point(8, 3);
            this.labelFixedSalary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFixedSalary.Name = "labelFixedSalary";
            this.labelFixedSalary.Size = new System.Drawing.Size(145, 15);
            this.labelFixedSalary.TabIndex = 1;
            this.labelFixedSalary.Text = "Оклад за полный месяц";
            // 
            // labelMonthlyWorkingDays
            // 
            this.labelMonthlyWorkingDays.AutoSize = true;
            this.labelMonthlyWorkingDays.Location = new System.Drawing.Point(8, 28);
            this.labelMonthlyWorkingDays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMonthlyWorkingDays.Name = "labelMonthlyWorkingDays";
            this.labelMonthlyWorkingDays.Size = new System.Drawing.Size(184, 15);
            this.labelMonthlyWorkingDays.TabIndex = 2;
            this.labelMonthlyWorkingDays.Text = "Кол-во рабочих дней в месяце";
            // 
            // labelActualWorkedDays
            // 
            this.labelActualWorkedDays.AutoSize = true;
            this.labelActualWorkedDays.Location = new System.Drawing.Point(8, 52);
            this.labelActualWorkedDays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelActualWorkedDays.Name = "labelActualWorkedDays";
            this.labelActualWorkedDays.Size = new System.Drawing.Size(166, 15);
            this.labelActualWorkedDays.TabIndex = 3;
            this.labelActualWorkedDays.Text = "Кол-во отработанных дней";
            // 
            // textBoxFixedSalary
            // 
            this.textBoxFixedSalary.Location = new System.Drawing.Point(194, 0);
            this.textBoxFixedSalary.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFixedSalary.Name = "textBoxFixedSalary";
            this.textBoxFixedSalary.Size = new System.Drawing.Size(55, 20);
            this.textBoxFixedSalary.TabIndex = 0;
            // 
            // textBoxMonthlyWorkingDays
            // 
            this.textBoxMonthlyWorkingDays.Location = new System.Drawing.Point(194, 25);
            this.textBoxMonthlyWorkingDays.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMonthlyWorkingDays.Name = "textBoxMonthlyWorkingDays";
            this.textBoxMonthlyWorkingDays.Size = new System.Drawing.Size(55, 20);
            this.textBoxMonthlyWorkingDays.TabIndex = 4;
            // 
            // textBoxActualWorkedDays
            // 
            this.textBoxActualWorkedDays.Location = new System.Drawing.Point(194, 49);
            this.textBoxActualWorkedDays.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxActualWorkedDays.Name = "textBoxActualWorkedDays";
            this.textBoxActualWorkedDays.Size = new System.Drawing.Size(55, 20);
            this.textBoxActualWorkedDays.TabIndex = 5;
            // 
            // SalaryMonthlyUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelFixedSalary);
            this.Controls.Add(this.labelMonthlyWorkingDays);
            this.Controls.Add(this.labelActualWorkedDays);
            this.Controls.Add(this.textBoxFixedSalary);
            this.Controls.Add(this.textBoxMonthlyWorkingDays);
            this.Controls.Add(this.textBoxActualWorkedDays);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SalaryMonthlyUserControl";
            this.Size = new System.Drawing.Size(260, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Label labelFixedSalary;
        internal Label labelMonthlyWorkingDays;
        internal Label labelActualWorkedDays;
        internal TextBox textBoxFixedSalary;
        internal TextBox textBoxMonthlyWorkingDays;
        internal TextBox textBoxActualWorkedDays;
    }
}
