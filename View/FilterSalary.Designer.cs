using System.Windows.Forms;
namespace View
{
    partial class FilterSalary
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
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.label = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.checkBoxInput = new System.Windows.Forms.CheckBox();
            this.checkBoxSalaryMonthly = new System.Windows.Forms.CheckBox();
            this.checkBoxSalaryTariffRate = new System.Windows.Forms.CheckBox();
            this.checkBoxSalaryHourlyRate = new System.Windows.Forms.CheckBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.label);
            this.groupBoxParameters.Controls.Add(this.textBoxSalary);
            this.groupBoxParameters.Controls.Add(this.checkBoxInput);
            this.groupBoxParameters.Controls.Add(this.checkBoxSalaryMonthly);
            this.groupBoxParameters.Controls.Add(this.checkBoxSalaryTariffRate);
            this.groupBoxParameters.Controls.Add(this.checkBoxSalaryHourlyRate);
            this.groupBoxParameters.Location = new System.Drawing.Point(9, 8);
            this.groupBoxParameters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxParameters.Size = new System.Drawing.Size(338, 151);
            this.groupBoxParameters.TabIndex = 0;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Параметры фильтрации";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(290, 126);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(42, 13);
            this.label.TabIndex = 5;
            this.label.Text = "рублей";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(181, 122);
            this.textBoxSalary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(95, 20);
            this.textBoxSalary.TabIndex = 4;
            // 
            // checkBoxInput
            // 
            this.checkBoxInput.AutoSize = true;
            this.checkBoxInput.Location = new System.Drawing.Point(10, 122);
            this.checkBoxInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxInput.Name = "checkBoxInput";
            this.checkBoxInput.Size = new System.Drawing.Size(162, 17);
            this.checkBoxInput.TabIndex = 3;
            this.checkBoxInput.Text = "Ввод необходимой суммы ";
            this.checkBoxInput.UseVisualStyleBackColor = true;
            // 
            // checkBoxSalaryMonthly
            // 
            this.checkBoxSalaryMonthly.AutoSize = true;
            this.checkBoxSalaryMonthly.Location = new System.Drawing.Point(10, 88);
            this.checkBoxSalaryMonthly.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxSalaryMonthly.Name = "checkBoxSalaryMonthly";
            this.checkBoxSalaryMonthly.Size = new System.Drawing.Size(108, 17);
            this.checkBoxSalaryMonthly.TabIndex = 2;
            this.checkBoxSalaryMonthly.Text = "Оклад за месяц";
            this.checkBoxSalaryMonthly.UseVisualStyleBackColor = true;
            // 
            // checkBoxSalaryTariffRate
            // 
            this.checkBoxSalaryTariffRate.AutoSize = true;
            this.checkBoxSalaryTariffRate.Location = new System.Drawing.Point(10, 55);
            this.checkBoxSalaryTariffRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxSalaryTariffRate.Name = "checkBoxSalaryTariffRate";
            this.checkBoxSalaryTariffRate.Size = new System.Drawing.Size(115, 17);
            this.checkBoxSalaryTariffRate.TabIndex = 1;
            this.checkBoxSalaryTariffRate.Text = "Тарифная ставка";
            this.checkBoxSalaryTariffRate.UseVisualStyleBackColor = true;
            // 
            // checkBoxSalaryHourlyRate
            // 
            this.checkBoxSalaryHourlyRate.AutoSize = true;
            this.checkBoxSalaryHourlyRate.Location = new System.Drawing.Point(10, 25);
            this.checkBoxSalaryHourlyRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxSalaryHourlyRate.Name = "checkBoxSalaryHourlyRate";
            this.checkBoxSalaryHourlyRate.Size = new System.Drawing.Size(160, 17);
            this.checkBoxSalaryHourlyRate.TabIndex = 0;
            this.checkBoxSalaryHourlyRate.Text = "Часовая тарифная ставка";
            this.checkBoxSalaryHourlyRate.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(9, 163);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(338, 26);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // FilterSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 196);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.groupBoxParameters);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FilterSalary";
            this.Text = "Фильтр по типу зарплаты";
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxParameters;
        private Label label;
        private TextBox textBoxSalary;
        private CheckBox checkBoxInput;
        private CheckBox checkBoxSalaryHourlyRate;
        private CheckBox checkBoxSalaryMonthly;
        private CheckBox checkBoxSalaryTariffRate;
        private Button buttonSearch;
    }
}