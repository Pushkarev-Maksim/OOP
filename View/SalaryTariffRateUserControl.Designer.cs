using System.Windows.Forms;
using View.Properties;

namespace View
{
    partial class SalaryTariffRateUserControl
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
            this.labelTariffRate = new System.Windows.Forms.Label();
            this.labelDays = new System.Windows.Forms.Label();
            this.textBoxTariffRate = new System.Windows.Forms.TextBox();
            this.textBoxDays = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTariffRate
            // 
            this.labelTariffRate.AutoSize = true;
            this.labelTariffRate.Location = new System.Drawing.Point(21, 10);
            this.labelTariffRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTariffRate.Name = "labelTariffRate";
            this.labelTariffRate.Size = new System.Drawing.Size(43, 13);
            this.labelTariffRate.TabIndex = 1;
            this.labelTariffRate.Text = "Тарифная ставка";
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Location = new System.Drawing.Point(21, 37);
            this.labelDays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(147, 13);
            this.labelDays.TabIndex = 0;
            this.labelDays.Text = "Кол-во отработанных дней";
            // 
            // textBoxTariffRate
            // 
            this.textBoxTariffRate.Location = new System.Drawing.Point(67, 10);
            this.textBoxTariffRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTariffRate.Name = "textBoxTariffRate";
            this.textBoxTariffRate.Size = new System.Drawing.Size(145, 20);
            this.textBoxTariffRate.TabIndex = 2;
            // 
            // textBoxDays
            // 
            this.textBoxDays.Location = new System.Drawing.Point(180, 37);
            this.textBoxDays.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDays.Name = "textBoxDays";
            this.textBoxDays.Size = new System.Drawing.Size(32, 20);
            this.textBoxDays.TabIndex = 3;
            // 
            // SalaryTariffRateUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 65);
            this.Controls.Add(this.labelTariffRate);
            this.Controls.Add(this.labelDays);
            this.Controls.Add(this.textBoxTariffRate);
            this.Controls.Add(this.textBoxDays);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SalaryTariffRateUserControl";
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