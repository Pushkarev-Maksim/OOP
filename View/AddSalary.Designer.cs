using System.Windows.Forms;
using View.Properties;

namespace View
{
    partial class AddSalary
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
            this._payrollMethod = new System.Windows.Forms.GroupBox();
            this._salaryTariffRate = new System.Windows.Forms.RadioButton();
            this._salaryMonthly = new System.Windows.Forms.RadioButton();
            this._salaryHourlyRate = new System.Windows.Forms.RadioButton();
            this._buttonOk = new System.Windows.Forms.Button();
            this._buttonClose = new System.Windows.Forms.Button();
            this._parametersSalary = new System.Windows.Forms.GroupBox();
            this._salaryTariffRateUserControl = new View.SalaryTariffRateUserControl();
            this._salaryMonthlyUserControl = new View.SalaryMonthlyUserControl();
            this._salaryHourlyRateUserControl = new View.SalaryHourlyRateUserControl();
            this._payrollMethod.SuspendLayout();
            this._parametersSalary.SuspendLayout();
            this.SuspendLayout();
            // 
            // _payrollMethod
            // 
            this._payrollMethod.Controls.Add(this._salaryTariffRate);
            this._payrollMethod.Controls.Add(this._salaryMonthly);
            this._payrollMethod.Controls.Add(this._salaryHourlyRate);
            this._payrollMethod.Location = new System.Drawing.Point(11, 11);
            this._payrollMethod.Margin = new System.Windows.Forms.Padding(2);
            this._payrollMethod.Name = "payrollMethod";
            this._payrollMethod.Padding = new System.Windows.Forms.Padding(2);
            this._payrollMethod.Size = new System.Drawing.Size(226, 98);
            this._payrollMethod.TabIndex = 7;
            this._payrollMethod.TabStop = false;
            this._payrollMethod.Text = "Выберите способ начисления зарплаты";
            // 
            // _salaryTariffRate
            // 
            this._salaryTariffRate.AutoSize = true;
            this._salaryTariffRate.Location = new System.Drawing.Point(6, 67);
            this._salaryTariffRate.Name = "salaryTariffRate";
            this._salaryTariffRate.Size = new System.Drawing.Size(114, 17);
            this._salaryTariffRate.TabIndex = 12;
            this._salaryTariffRate.Text = "Тарифная ставка";
            this._salaryTariffRate.UseVisualStyleBackColor = true;
            this._salaryTariffRate.CheckedChanged += new System.EventHandler(this.ChangeSalaryTariffRate);
            // 
            // _salaryMonthly
            // 
            this._salaryMonthly.AutoSize = true;
            this._salaryMonthly.Location = new System.Drawing.Point(6, 43);
            this._salaryMonthly.Name = "salaryMonthly";
            this._salaryMonthly.Size = new System.Drawing.Size(107, 17);
            this._salaryMonthly.TabIndex = 11;
            this._salaryMonthly.Text = "Оклад за месяц";
            this._salaryMonthly.UseVisualStyleBackColor = true;
            this._salaryMonthly.CheckedChanged += new System.EventHandler(this.ChangeSalaryMonthly);
            // 
            // _salaryHourlyRate
            // 
            this._salaryHourlyRate.AutoSize = true;
            this._salaryHourlyRate.Location = new System.Drawing.Point(6, 19);
            this._salaryHourlyRate.Name = "salaryHourlyRate";
            this._salaryHourlyRate.Size = new System.Drawing.Size(159, 17);
            this._salaryHourlyRate.TabIndex = 10;
            this._salaryHourlyRate.Text = "Часовая тарифная ставка";
            this._salaryHourlyRate.CheckedChanged += new System.EventHandler(this.ChangeSalaryHourlyRate);
            // 
            // _buttonOk
            // 
            this._buttonOk.Location = new System.Drawing.Point(329, 113);
            this._buttonOk.Margin = new System.Windows.Forms.Padding(2);
            this._buttonOk.Name = "buttonOk";
            this._buttonOk.Size = new System.Drawing.Size(97, 28);
            this._buttonOk.TabIndex = 13;
            this._buttonOk.Text = "Ок";
            this._buttonOk.UseVisualStyleBackColor = true;
            this._buttonOk.Click += new System.EventHandler(this.ClickButtonAdd);
            // 
            // _buttonClose
            // 
            this._buttonClose.Location = new System.Drawing.Point(430, 113);
            this._buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this._buttonClose.Name = "buttonClose";
            this._buttonClose.Size = new System.Drawing.Size(97, 28);
            this._buttonClose.TabIndex = 14;
            this._buttonClose.Text = "Закрыть";
            this._buttonClose.UseVisualStyleBackColor = true;
            this._buttonClose.Click += new System.EventHandler(this.ClickButtonClose);
            // 
            // _parametersSalary
            // 
            this._parametersSalary.Controls.Add(this._salaryMonthlyUserControl);
            this._parametersSalary.Controls.Add(this._salaryMonthlyUserControl);
            this._parametersSalary.Controls.Add(this._salaryMonthlyUserControl);
            this._parametersSalary.Location = new System.Drawing.Point(255, 11);
            this._parametersSalary.Margin = new System.Windows.Forms.Padding(2);
            this._parametersSalary.Name = "parametersSalary";
            this._parametersSalary.Padding = new System.Windows.Forms.Padding(2);
            this._parametersSalary.Size = new System.Drawing.Size(272, 98);
            this._parametersSalary.TabIndex = 10;
            this._parametersSalary.TabStop = false;
            this._parametersSalary.Text = "Параметры начисления зарплаты";
            // 
            // _salaryTariffRateUserControl
            // 
            this._salaryTariffRateUserControl.Location = new System.Drawing.Point(6, 19);
            this._salaryTariffRateUserControl.Margin = new System.Windows.Forms.Padding(2);
            this._salaryTariffRateUserControl.Name = "salaryTariffRateUserControl";
            this._salaryTariffRateUserControl.Size = new System.Drawing.Size(259, 56);
            this._salaryTariffRateUserControl.TabIndex = 2;
            this._salaryTariffRateUserControl.Visible = false;
            // 
            // _salaryMonthlyUserControl
            // 
            this._salaryMonthlyUserControl.Location = new System.Drawing.Point(6, 19);
            this._salaryMonthlyUserControl.Margin = new System.Windows.Forms.Padding(2);
            this._salaryMonthlyUserControl.Name = "salaryMonthlyUserControl";
            this._salaryMonthlyUserControl.Size = new System.Drawing.Size(261, 75);
            this._salaryMonthlyUserControl.TabIndex = 1;
            this._salaryMonthlyUserControl.Visible = false;
            // 
            // _salaryHourlyRateUserControl
            // 
            this._salaryHourlyRateUserControl.Location = new System.Drawing.Point(6, 17);
            this._salaryHourlyRateUserControl.Margin = new System.Windows.Forms.Padding(2);
            this._salaryHourlyRateUserControl.Name = "salaryHourlyRateUserControl";
            this._salaryHourlyRateUserControl.Size = new System.Drawing.Size(258, 79);
            this._salaryHourlyRateUserControl.TabIndex = 0;
            this._salaryHourlyRateUserControl.Visible = false;
            // 
            // AddSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 150);
            this.Controls.Add(this._payrollMethod);
            this.Controls.Add(this._parametersSalary);
            this.Controls.Add(this._buttonOk);
            this.Controls.Add(this._buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AddSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление зарплаты";
            this._payrollMethod.ResumeLayout(false);
            this._payrollMethod.PerformLayout();
            this._parametersSalary.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox _payrollMethod;
        private Button _buttonOk;
        private Button _buttonClose;
        private RadioButton _salaryTariffRate;
        private RadioButton _salaryMonthly;
        private RadioButton _salaryHourlyRate;
        private GroupBox _parametersSalary;
        private SalaryTariffRateUserControl _salaryTariffRateUserControl;
        private SalaryMonthlyUserControl _salaryMonthlyUserControl;
        private SalaryHourlyRateUserControl _salaryHourlyRateUserControl;
    }
}