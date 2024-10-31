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
            this._groupBoxParameters = new System.Windows.Forms.GroupBox();
            this._label = new System.Windows.Forms.Label();
            this._textBoxSalary = new System.Windows.Forms.TextBox();
            this._checkBoxInput = new System.Windows.Forms.CheckBox();
            this._checkBoxSalaryMonthly = new System.Windows.Forms.CheckBox();
            this._checkBoxSalaryTariffRate = new System.Windows.Forms.CheckBox();
            this._checkBoxSalaryHourlyRate = new System.Windows.Forms.CheckBox();
            this._buttonSearch = new System.Windows.Forms.Button();
            this._groupBoxParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // _groupBoxParameters
            // 
            this._groupBoxParameters.Controls.Add(this._label);
            this._groupBoxParameters.Controls.Add(this._textBoxSalary);
            this._groupBoxParameters.Controls.Add(this._checkBoxInput);
            this._groupBoxParameters.Controls.Add(this._checkBoxSalaryMonthly);
            this._groupBoxParameters.Controls.Add(this._checkBoxSalaryTariffRate);
            this._groupBoxParameters.Controls.Add(this._checkBoxSalaryHourlyRate);
            this._groupBoxParameters.Location = new System.Drawing.Point(8, 8);
            this._groupBoxParameters.Margin = new System.Windows.Forms.Padding(2);
            this._groupBoxParameters.Name = "groupBoxParameters";
            this._groupBoxParameters.Padding = new System.Windows.Forms.Padding(2);
            this._groupBoxParameters.Size = new System.Drawing.Size(338, 123);
            this._groupBoxParameters.TabIndex = 0;
            this._groupBoxParameters.TabStop = false;
            this._groupBoxParameters.Text = "Параметры фильтрации";
            // 
            // _label
            // 
            this._label.AutoSize = true;
            this._label.Location = new System.Drawing.Point(281, 96);
            this._label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._label.Name = "label";
            this._label.Size = new System.Drawing.Size(27, 13);
            this._label.TabIndex = 5;
            this._label.Text = "руб.";
            // 
            // _textBoxSalary
            // 
            this._textBoxSalary.Location = new System.Drawing.Point(182, 93);
            this._textBoxSalary.Margin = new System.Windows.Forms.Padding(2);
            this._textBoxSalary.MaxLength = 7;
            this._textBoxSalary.Name = "textBoxSalary";
            this._textBoxSalary.Size = new System.Drawing.Size(95, 20);
            this._textBoxSalary.TabIndex = 4;
            // 
            // _checkBoxInput
            // 
            this._checkBoxInput.AutoSize = true;
            this._checkBoxInput.Location = new System.Drawing.Point(10, 94);
            this._checkBoxInput.Margin = new System.Windows.Forms.Padding(2);
            this._checkBoxInput.Name = "checkBoxInput";
            this._checkBoxInput.Size = new System.Drawing.Size(174, 17);
            this._checkBoxInput.TabIndex = 3;
            this._checkBoxInput.Text = "Введите необходимую сумму";
            this._checkBoxInput.UseVisualStyleBackColor = true;
            this._checkBoxInput.CheckedChanged += new System.EventHandler(this.ActivateTextBox);
            // 
            // _checkBoxSalaryMonthly
            // 
            this._checkBoxSalaryMonthly.AutoSize = true;
            this._checkBoxSalaryMonthly.Location = new System.Drawing.Point(10, 48);
            this._checkBoxSalaryMonthly.Margin = new System.Windows.Forms.Padding(2);
            this._checkBoxSalaryMonthly.Name = "checkBoxSalaryMonthly";
            this._checkBoxSalaryMonthly.Size = new System.Drawing.Size(108, 17);
            this._checkBoxSalaryMonthly.TabIndex = 1;
            this._checkBoxSalaryMonthly.Text = "Оклад за месяц";
            this._checkBoxSalaryMonthly.UseVisualStyleBackColor = true;
            // 
            // _checkBoxSalaryTariffRate
            // 
            this._checkBoxSalaryTariffRate.AutoSize = true;
            this._checkBoxSalaryTariffRate.Location = new System.Drawing.Point(10, 71);
            this._checkBoxSalaryTariffRate.Margin = new System.Windows.Forms.Padding(2);
            this._checkBoxSalaryTariffRate.Name = "checkBoxSalaryTariffRate";
            this._checkBoxSalaryTariffRate.Size = new System.Drawing.Size(115, 17);
            this._checkBoxSalaryTariffRate.TabIndex = 2;
            this._checkBoxSalaryTariffRate.Text = "Тарифная ставка";
            this._checkBoxSalaryTariffRate.UseVisualStyleBackColor = true;
            // 
            // _checkBoxSalaryHourlyRate
            // 
            this._checkBoxSalaryHourlyRate.AutoSize = true;
            this._checkBoxSalaryHourlyRate.Location = new System.Drawing.Point(10, 25);
            this._checkBoxSalaryHourlyRate.Margin = new System.Windows.Forms.Padding(2);
            this._checkBoxSalaryHourlyRate.Name = "checkBoxSalaryHourlyRate";
            this._checkBoxSalaryHourlyRate.Size = new System.Drawing.Size(160, 17);
            this._checkBoxSalaryHourlyRate.TabIndex = 0;
            this._checkBoxSalaryHourlyRate.Text = "Часовая тарифная ставка";
            this._checkBoxSalaryHourlyRate.UseVisualStyleBackColor = true;
            // 
            // _buttonSearch
            // 
            this._buttonSearch.Location = new System.Drawing.Point(8, 135);
            this._buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this._buttonSearch.Name = "buttonSearch";
            this._buttonSearch.Size = new System.Drawing.Size(338, 26);
            this._buttonSearch.TabIndex = 5;
            this._buttonSearch.Text = "Найти";
            this._buttonSearch.UseVisualStyleBackColor = true;
            this._buttonSearch.Click += new System.EventHandler(this.Filter);
            // 
            // FilterSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 169);
            this.Controls.Add(this._buttonSearch);
            this.Controls.Add(this._groupBoxParameters);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FilterSalary";
            this.Text = "Фильтр по типу зарплаты";
            this._groupBoxParameters.ResumeLayout(false);
            this._groupBoxParameters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox _groupBoxParameters;
        private Label _label;
        private TextBox _textBoxSalary;
        private CheckBox _checkBoxInput;
        private CheckBox _checkBoxSalaryHourlyRate;
        private CheckBox _checkBoxSalaryMonthly;
        private CheckBox _checkBoxSalaryTariffRate;
        private Button _buttonSearch;
    }
}