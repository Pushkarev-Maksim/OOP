using System.Windows.Forms;

namespace View
{
    partial class SalaryHourlyRateUserControl
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
            this._labelHourlyRate = new System.Windows.Forms.Label();
            this._labelHours = new System.Windows.Forms.Label();
            this._textBoxHourlyRate = new System.Windows.Forms.TextBox();
            this._textBoxHours = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelHourlyRate
            // 
            this._labelHourlyRate.AutoSize = true;
            this._labelHourlyRate.Location = new System.Drawing.Point(8, 4);
            this._labelHourlyRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._labelHourlyRate.Name = "labelHourlyRate";
            this._labelHourlyRate.Size = new System.Drawing.Size(141, 13);
            this._labelHourlyRate.TabIndex = 0;
            this._labelHourlyRate.Text = "Часовая тарифная ставка";
            // 
            // labelHours
            // 
            this._labelHours.AutoSize = true;
            this._labelHours.Location = new System.Drawing.Point(8, 29);
            this._labelHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._labelHours.Name = "labelHours";
            this._labelHours.Size = new System.Drawing.Size(147, 13);
            this._labelHours.TabIndex = 1;
            this._labelHours.Text = "Кол-во отработанных часов";
            // 
            // textBoxHourlyRate
            // 
            this._textBoxHourlyRate.Location = new System.Drawing.Point(195, 2);
            this._textBoxHourlyRate.Margin = new System.Windows.Forms.Padding(2);
            this._textBoxHourlyRate.MaxLength = 7;
            this._textBoxHourlyRate.Name = "textBoxHourlyRate";
            this._textBoxHourlyRate.Size = new System.Drawing.Size(55, 20);
            this._textBoxHourlyRate.TabIndex = 2;
            // 
            // textBoxHours
            // 
            this._textBoxHours.Location = new System.Drawing.Point(195, 26);
            this._textBoxHours.Margin = new System.Windows.Forms.Padding(2);
            this._textBoxHours.MaxLength = 7;
            this._textBoxHours.Name = "textBoxHours";
            this._textBoxHours.Size = new System.Drawing.Size(55, 20);
            this._textBoxHours.TabIndex = 3;
            // 
            // SalaryHourlyRateUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._textBoxHours);
            this.Controls.Add(this._textBoxHourlyRate);
            this.Controls.Add(this._labelHours);
            this.Controls.Add(this._labelHourlyRate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SalaryHourlyRateUserControl";
            this.Size = new System.Drawing.Size(260, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Label _labelHourlyRate;
        internal Label _labelHours;
        internal TextBox _textBoxHourlyRate;
        internal TextBox _textBoxHours;
    }
}
