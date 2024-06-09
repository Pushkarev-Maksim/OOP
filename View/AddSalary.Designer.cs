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
            this.selectionSalary = new System.Windows.Forms.ComboBox();
            this.parametersSalary = new System.Windows.Forms.GroupBox();
            this.salaryHourlyRateUserControl = new View.SalaryHourlyRateUserControl();
            this.salaryMonthlyUserControl = new View.SalaryMonthlyUserControl();
            this.salaryTariffRateUserControl = new View.SalaryTariffRateUserControl();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.payrollMethod.SuspendLayout();
            this.parametersSalary.SuspendLayout();
            this.SuspendLayout();
            // 
            // payrollMethod
            // 
            this.payrollMethod.Controls.Add(this.selectionSalary);
            this.payrollMethod.Location = new System.Drawing.Point(44, 28);
            this.payrollMethod.Name = "payrollMethod";
            this.payrollMethod.Size = new System.Drawing.Size(314, 112);
            this.payrollMethod.TabIndex = 7;
            this.payrollMethod.TabStop = false;
            this.payrollMethod.Text = "Способ начисления зарплаты";
            //this.payrollMethod.Enter += new System.EventHandler(this.payrollMethod_Enter);
            // 
            // parametersSalary
            // 
            this.parametersSalary.Controls.Add(this.salaryHourlyRateUserControl);
            this.parametersSalary.Controls.Add(this.salaryMonthlyUserControl);
            this.parametersSalary.Controls.Add(this.salaryTariffRateUserControl);
            this.parametersSalary.Location = new System.Drawing.Point(44, 146);
            this.parametersSalary.Name = "parametersSalary";
            this.parametersSalary.Size = new System.Drawing.Size(314, 150);
            this.parametersSalary.TabIndex = 10;
            this.parametersSalary.TabStop = false;
            this.parametersSalary.Text = "Параметры начисления зарплаты";
            //this.accrualParameters.Enter += new System.EventHandler(this.accrualParameters_Enter);
            // 
            // selectionSalary
            // 
            this.selectionSalary.FormattingEnabled = true;
            this.selectionSalary.Location = new System.Drawing.Point(22, 49);
            this.selectionSalary.Name = "selectionSalary";
            this.selectionSalary.Size = new System.Drawing.Size(269, 28);
            this.selectionSalary.TabIndex = 9;
            //this.selectionSalary.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSalarySelection);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(50, 302);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(129, 33);
            this.buttonOk.TabIndex = 13;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            //this.buttonOk.Click += new System.EventHandler(this.ButtonOk);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(217, 302);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(129, 33);
            this.buttonClose.TabIndex = 14;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            //this.buttonClose.Click += new System.EventHandler(this.ButtonClose);
            // 
            // salaryHourlyRateUserControl
            // 
            this.salaryHourlyRateUserControl.Location = new System.Drawing.Point(6, 26);
            this.salaryHourlyRateUserControl.Name = "salaryHourlyRateUserControl";
            this.salaryHourlyRateUserControl.Size = new System.Drawing.Size(296, 118);
            this.salaryHourlyRateUserControl.TabIndex = 1;
            // 
            // salaryMonthlyUserControl
            // 
            this.salaryMonthlyUserControl.Location = new System.Drawing.Point(6, 40);
            this.salaryMonthlyUserControl.Name = "salaryMonthlyUserControl";
            this.salaryMonthlyUserControl.Size = new System.Drawing.Size(302, 91);
            this.salaryMonthlyUserControl.TabIndex = 2;
            //this.salaryMonthlyUserControl.Load += new System.EventHandler(this.wageRateUserControl1_Load);
            // 
            // salaryTariffRateUserControl
            // 
            this.salaryTariffRateUserControl.Location = new System.Drawing.Point(6, 26);
            this.salaryTariffRateUserControl.Name = "salaryTariffRateUserControl";
            this.salaryTariffRateUserControl.Size = new System.Drawing.Size(302, 90);
            this.salaryTariffRateUserControl.TabIndex = 0;
            // 
            // AddSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 410);
            this.Controls.Add(this.payrollMethod);
            this.Controls.Add(this.parametersSalary);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление зарплаты";
            //this.Load += new System.EventHandler(this.SalaryLoad);
            this.payrollMethod.ResumeLayout(false);
            this.parametersSalary.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox payrollMethod;
        private GroupBox parametersSalary;
        private ComboBox selectionSalary;
        private Button buttonOk;
        private Button buttonClose;
        private SalaryHourlyRateUserControl salaryHourlyRateUserControl;
        private SalaryMonthlyUserControl salaryMonthlyUserControl;
        private SalaryTariffRateUserControl salaryTariffRateUserControl;
    }
}