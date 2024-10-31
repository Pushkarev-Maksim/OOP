using System.Windows.Forms;

namespace View
{
    partial class SalaryTariffRateUserControl
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
            this._labelTariffRate = new System.Windows.Forms.Label();
            this._labelDays = new System.Windows.Forms.Label();
            this._textBoxTariffRate = new System.Windows.Forms.TextBox();
            this._textBoxDays = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _labelTariffRate
            // 
            this._labelTariffRate.AutoSize = true;
            this._labelTariffRate.Location = new System.Drawing.Point(8, 5);
            this._labelTariffRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._labelTariffRate.Name = "labelTariffRate";
            this._labelTariffRate.Size = new System.Drawing.Size(96, 13);
            this._labelTariffRate.TabIndex = 1;
            this._labelTariffRate.Text = "Тарифная ставка";
            // 
            // _labelDays
            // 
            this._labelDays.AutoSize = true;
            this._labelDays.Location = new System.Drawing.Point(8, 29);
            this._labelDays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._labelDays.Name = "labelDays";
            this._labelDays.Size = new System.Drawing.Size(142, 13);
            this._labelDays.TabIndex = 0;
            this._labelDays.Text = "Кол-во отработанных дней";
            // 
            // _textBoxTariffRate
            // 
            this._textBoxTariffRate.Location = new System.Drawing.Point(195, 2);
            this._textBoxTariffRate.Margin = new System.Windows.Forms.Padding(2);
            this._textBoxTariffRate.MaxLength = 7;
            this._textBoxTariffRate.Name = "textBoxTariffRate";
            this._textBoxTariffRate.Size = new System.Drawing.Size(55, 20);
            this._textBoxTariffRate.TabIndex = 2;
            // 
            // _textBoxDays
            // 
            this._textBoxDays.Location = new System.Drawing.Point(195, 26);
            this._textBoxDays.Margin = new System.Windows.Forms.Padding(2);
            this._textBoxDays.MaxLength = 7;
            this._textBoxDays.Name = "textBoxDays";
            this._textBoxDays.Size = new System.Drawing.Size(55, 20);
            this._textBoxDays.TabIndex = 3;
            // 
            // SalaryTariffRateUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._labelTariffRate);
            this.Controls.Add(this._labelDays);
            this.Controls.Add(this._textBoxTariffRate);
            this.Controls.Add(this._textBoxDays);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SalaryTariffRateUserControl";
            this.Size = new System.Drawing.Size(260, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Label _labelTariffRate;
        internal Label _labelDays;
        internal TextBox _textBoxTariffRate;
        internal TextBox _textBoxDays;
    }
}