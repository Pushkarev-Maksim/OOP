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
            this.payrollMethod = new System.Windows.Forms.GroupBox();
            this.salaryTariffRate = new System.Windows.Forms.RadioButton();
            this.salaryMonthly = new System.Windows.Forms.RadioButton();
            this.salaryHourlyRate = new System.Windows.Forms.RadioButton();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.parametersSalary = new System.Windows.Forms.GroupBox();
            this.salaryTariffRateUserControl = new View.SalaryTariffRateUserControl();
            this.salaryMonthlyUserControl = new View.SalaryMonthlyUserControl();
            this.salaryHourlyRateUserControl = new View.SalaryHourlyRateUserControl();
            this.payrollMethod.SuspendLayout();
            this.parametersSalary.SuspendLayout();
            this.SuspendLayout();
            // 
            // payrollMethod
            // 
            this.payrollMethod.Controls.Add(this.salaryTariffRate);
            this.payrollMethod.Controls.Add(this.salaryMonthly);
            this.payrollMethod.Controls.Add(this.salaryHourlyRate);
            this.payrollMethod.Location = new System.Drawing.Point(15, 14);
            this.payrollMethod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.payrollMethod.Name = "payrollMethod";
            this.payrollMethod.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.payrollMethod.Size = new System.Drawing.Size(305, 140);
            this.payrollMethod.TabIndex = 7;
            this.payrollMethod.TabStop = false;
            this.payrollMethod.Text = "Выберите способ начисления зарплаты";
            // 
            // salaryTariffRate
            // 
            this.salaryTariffRate.AutoSize = true;
            this.salaryTariffRate.Location = new System.Drawing.Point(8, 82);
            this.salaryTariffRate.Margin = new System.Windows.Forms.Padding(4);
            this.salaryTariffRate.Name = "salaryTariffRate";
            this.salaryTariffRate.Size = new System.Drawing.Size(143, 20);
            this.salaryTariffRate.TabIndex = 12;
            this.salaryTariffRate.Text = "Тарифная ставка";
            this.salaryTariffRate.UseVisualStyleBackColor = true;
            this.salaryTariffRate.CheckedChanged += new System.EventHandler(this.salaryTariffRate_CheckedChanged);
            // 
            // salaryMonthly
            // 
            this.salaryMonthly.AutoSize = true;
            this.salaryMonthly.Location = new System.Drawing.Point(8, 53);
            this.salaryMonthly.Margin = new System.Windows.Forms.Padding(4);
            this.salaryMonthly.Name = "salaryMonthly";
            this.salaryMonthly.Size = new System.Drawing.Size(130, 20);
            this.salaryMonthly.TabIndex = 11;
            this.salaryMonthly.Text = "Оклад за месяц";
            this.salaryMonthly.UseVisualStyleBackColor = true;
            this.salaryMonthly.CheckedChanged += new System.EventHandler(this.salaryMonthly_CheckedChanged);
            // 
            // salaryHourlyRate
            // 
            this.salaryHourlyRate.AutoSize = true;
            this.salaryHourlyRate.Location = new System.Drawing.Point(8, 23);
            this.salaryHourlyRate.Margin = new System.Windows.Forms.Padding(4);
            this.salaryHourlyRate.Name = "salaryHourlyRate";
            this.salaryHourlyRate.Size = new System.Drawing.Size(199, 20);
            this.salaryHourlyRate.TabIndex = 10;
            this.salaryHourlyRate.Text = "Часовая тарифная ставка";
            this.salaryHourlyRate.CheckedChanged += new System.EventHandler(this.salaryHourlyRate_CheckedChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(505, 159);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(129, 34);
            this.buttonOk.TabIndex = 13;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(640, 159);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(129, 34);
            this.buttonClose.TabIndex = 14;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // parametersSalary
            // 
            this.parametersSalary.Controls.Add(this.salaryTariffRateUserControl);
            this.parametersSalary.Controls.Add(this.salaryMonthlyUserControl);
            this.parametersSalary.Controls.Add(this.salaryHourlyRateUserControl);
            this.parametersSalary.Location = new System.Drawing.Point(340, 14);
            this.parametersSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parametersSalary.Name = "parametersSalary";
            this.parametersSalary.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parametersSalary.Size = new System.Drawing.Size(377, 140);
            this.parametersSalary.TabIndex = 10;
            this.parametersSalary.TabStop = false;
            this.parametersSalary.Text = "Параметры начисления зарплаты";
            // 
            // salaryTariffRateUserControl
            // 
            this.salaryTariffRateUserControl.Location = new System.Drawing.Point(9, 23);
            this.salaryTariffRateUserControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salaryTariffRateUserControl.Name = "salaryTariffRateUserControl";
            this.salaryTariffRateUserControl.Size = new System.Drawing.Size(345, 106);
            this.salaryTariffRateUserControl.TabIndex = 2;
            this.salaryTariffRateUserControl.Visible = false;
            // 
            // salaryMonthlyUserControl
            // 
            this.salaryMonthlyUserControl.Location = new System.Drawing.Point(6, 23);
            this.salaryMonthlyUserControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salaryMonthlyUserControl.Name = "salaryMonthlyUserControl";
            this.salaryMonthlyUserControl.Size = new System.Drawing.Size(348, 97);
            this.salaryMonthlyUserControl.TabIndex = 1;
            this.salaryMonthlyUserControl.Visible = false;
            // 
            // salaryHourlyRateUserControl
            // 
            this.salaryHourlyRateUserControl.Location = new System.Drawing.Point(6, 19);
            this.salaryHourlyRateUserControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salaryHourlyRateUserControl.Name = "salaryHourlyRateUserControl";
            this.salaryHourlyRateUserControl.Size = new System.Drawing.Size(344, 97);
            this.salaryHourlyRateUserControl.TabIndex = 0;
            this.salaryHourlyRateUserControl.Visible = false;
            // 
            // AddSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 207);
            this.Controls.Add(this.payrollMethod);
            this.Controls.Add(this.parametersSalary);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "AddSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление зарплаты";
            this.payrollMethod.ResumeLayout(false);
            this.payrollMethod.PerformLayout();
            this.parametersSalary.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox payrollMethod;
        private Button buttonOk;
        private Button buttonClose;
        private RadioButton salaryTariffRate;
        private RadioButton salaryMonthly;
        private RadioButton salaryHourlyRate;
        private GroupBox parametersSalary;
        private SalaryTariffRateUserControl salaryTariffRateUserControl;
        private SalaryMonthlyUserControl salaryMonthlyUserControl;
        private SalaryHourlyRateUserControl salaryHourlyRateUserControl;
    }
}