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
            this._labelFixedSalary = new System.Windows.Forms.Label();
            this._labelMonthlyWorkingDays = new System.Windows.Forms.Label();
            this._labelActualWorkedDays = new System.Windows.Forms.Label();
            this._textBoxFixedSalary = new System.Windows.Forms.TextBox();
            this._textBoxMonthlyWorkingDays = new System.Windows.Forms.TextBox();
            this._textBoxActualWorkedDays = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _labelFixedSalary
            // 
            this._labelFixedSalary.AutoSize = true;
            this._labelFixedSalary.Location = new System.Drawing.Point(8, 3);
            this._labelFixedSalary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._labelFixedSalary.Name = "labelFixedSalary";
            this._labelFixedSalary.Size = new System.Drawing.Size(130, 13);
            this._labelFixedSalary.TabIndex = 1;
            this._labelFixedSalary.Text = "Оклад за полный месяц";
            // 
            // _labelMonthlyWorkingDays
            // 
            this._labelMonthlyWorkingDays.AutoSize = true;
            this._labelMonthlyWorkingDays.Location = new System.Drawing.Point(8, 28);
            this._labelMonthlyWorkingDays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._labelMonthlyWorkingDays.Name = "labelMonthlyWorkingDays";
            this._labelMonthlyWorkingDays.Size = new System.Drawing.Size(161, 13);
            this._labelMonthlyWorkingDays.TabIndex = 2;
            this._labelMonthlyWorkingDays.Text = "Кол-во рабочих дней в месяце";
            // 
            // _labelActualWorkedDays
            // 
            this._labelActualWorkedDays.AutoSize = true;
            this._labelActualWorkedDays.Location = new System.Drawing.Point(8, 52);
            this._labelActualWorkedDays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._labelActualWorkedDays.Name = "labelActualWorkedDays";
            this._labelActualWorkedDays.Size = new System.Drawing.Size(142, 13);
            this._labelActualWorkedDays.TabIndex = 3;
            this._labelActualWorkedDays.Text = "Кол-во отработанных дней";
            // 
            // _textBoxFixedSalary
            // 
            this._textBoxFixedSalary.Location = new System.Drawing.Point(194, 0);
            this._textBoxFixedSalary.Margin = new System.Windows.Forms.Padding(2);
            this._textBoxFixedSalary.MaxLength = 7;
            this._textBoxFixedSalary.Name = "textBoxFixedSalary";
            this._textBoxFixedSalary.Size = new System.Drawing.Size(55, 20);
            this._textBoxFixedSalary.TabIndex = 0;
            // 
            // _textBoxMonthlyWorkingDays
            // 
            this._textBoxMonthlyWorkingDays.Location = new System.Drawing.Point(194, 25);
            this._textBoxMonthlyWorkingDays.Margin = new System.Windows.Forms.Padding(2);
            this._textBoxMonthlyWorkingDays.MaxLength = 7;
            this._textBoxMonthlyWorkingDays.Name = "textBoxMonthlyWorkingDays";
            this._textBoxMonthlyWorkingDays.Size = new System.Drawing.Size(55, 20);
            this._textBoxMonthlyWorkingDays.TabIndex = 4;
            // 
            // _textBoxActualWorkedDays
            // 
            this._textBoxActualWorkedDays.Location = new System.Drawing.Point(194, 49);
            this._textBoxActualWorkedDays.Margin = new System.Windows.Forms.Padding(2);
            this._textBoxActualWorkedDays.MaxLength = 7;
            this._textBoxActualWorkedDays.Name = "textBoxActualWorkedDays";
            this._textBoxActualWorkedDays.Size = new System.Drawing.Size(55, 20);
            this._textBoxActualWorkedDays.TabIndex = 5;
            // 
            // SalaryMonthlyUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._labelFixedSalary);
            this.Controls.Add(this._labelMonthlyWorkingDays);
            this.Controls.Add(this._labelActualWorkedDays);
            this.Controls.Add(this._textBoxFixedSalary);
            this.Controls.Add(this._textBoxMonthlyWorkingDays);
            this.Controls.Add(this._textBoxActualWorkedDays);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SalaryMonthlyUserControl";
            this.Size = new System.Drawing.Size(260, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Label _labelFixedSalary;
        internal Label _labelMonthlyWorkingDays;
        internal Label _labelActualWorkedDays;
        internal TextBox _textBoxFixedSalary;
        internal TextBox _textBoxMonthlyWorkingDays;
        internal TextBox _textBoxActualWorkedDays;
    }
}
