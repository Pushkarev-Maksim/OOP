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
            this.labelHourlyRate = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.textBoxHourlyRate = new System.Windows.Forms.TextBox();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelHourlyRate
            // 
            this.labelHourlyRate.AutoSize = true;
            this.labelHourlyRate.Location = new System.Drawing.Point(11, 5);
            this.labelHourlyRate.Name = "labelHourlyRate";
            this.labelHourlyRate.Size = new System.Drawing.Size(178, 16);
            this.labelHourlyRate.TabIndex = 0;
            this.labelHourlyRate.Text = "Часовая тарифная ставка";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(11, 31);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(189, 16);
            this.labelHours.TabIndex = 1;
            this.labelHours.Text = "Кол-во отработанных часов";
            // 
            // textBoxHourlyRate
            // 
            this.textBoxHourlyRate.Location = new System.Drawing.Point(260, 2);
            this.textBoxHourlyRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxHourlyRate.Name = "textBoxHourlyRate";
            this.textBoxHourlyRate.Size = new System.Drawing.Size(72, 22);
            this.textBoxHourlyRate.TabIndex = 2;
            // 
            // textBoxHours
            // 
            this.textBoxHours.Location = new System.Drawing.Point(260, 28);
            this.textBoxHours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(72, 22);
            this.textBoxHours.TabIndex = 3;
            // 
            // SalaryHourlyRateUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxHours);
            this.Controls.Add(this.textBoxHourlyRate);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.labelHourlyRate);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SalaryHourlyRateUserControl";
            this.Size = new System.Drawing.Size(347, 98);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelHourlyRate;
        private Label labelHours;
        private TextBox textBoxHourlyRate;
        private TextBox textBoxHours;
    }
}
