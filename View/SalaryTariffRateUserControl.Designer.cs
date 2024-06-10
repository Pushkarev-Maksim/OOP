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
            this.labelTariffRate = new System.Windows.Forms.Label();
            this.labelDays = new System.Windows.Forms.Label();
            this.textBoxTariffRate = new System.Windows.Forms.TextBox();
            this.textBoxDays = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTariffRate
            // 
            this.labelTariffRate.AutoSize = true;
            this.labelTariffRate.Location = new System.Drawing.Point(11, 0);
            this.labelTariffRate.Name = "labelTariffRate";
            this.labelTariffRate.Size = new System.Drawing.Size(122, 16);
            this.labelTariffRate.TabIndex = 1;
            this.labelTariffRate.Text = "Тарифная ставка";
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Location = new System.Drawing.Point(11, 31);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(182, 16);
            this.labelDays.TabIndex = 0;
            this.labelDays.Text = "Кол-во отработанных дней";
            // 
            // textBoxTariffRate
            // 
            this.textBoxTariffRate.Location = new System.Drawing.Point(260, 2);
            this.textBoxTariffRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTariffRate.Name = "textBoxTariffRate";
            this.textBoxTariffRate.Size = new System.Drawing.Size(72, 22);
            this.textBoxTariffRate.TabIndex = 2;
            // 
            // textBoxDays
            // 
            this.textBoxDays.Location = new System.Drawing.Point(260, 28);
            this.textBoxDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDays.Name = "textBoxDays";
            this.textBoxDays.Size = new System.Drawing.Size(72, 22);
            this.textBoxDays.TabIndex = 3;
            // 
            // SalaryTariffRateUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelTariffRate);
            this.Controls.Add(this.labelDays);
            this.Controls.Add(this.textBoxTariffRate);
            this.Controls.Add(this.textBoxDays);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SalaryTariffRateUserControl";
            this.Size = new System.Drawing.Size(347, 98);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTariffRate;
        private Label labelDays;
        private TextBox textBoxTariffRate;
        private TextBox textBoxDays;
    }
}
