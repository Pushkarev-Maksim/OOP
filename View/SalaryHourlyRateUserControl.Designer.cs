using System.Windows.Forms;
using View.Properties;

namespace View
{
    partial class SalaryHourlyRateUserControl
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
            this.labelHourlyRate = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.textBoxHourlyRate = new System.Windows.Forms.TextBox();
            this.textBoxHour = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelHourlyRate
            // 
            this.labelHourlyRate.AutoSize = true;
            this.labelHourlyRate.Location = new System.Drawing.Point(14, 13);
            this.labelHourlyRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHourlyRate.Name = "labelHourlyRate";
            this.labelHourlyRate.Size = new System.Drawing.Size(141, 13);
            this.labelHourlyRate.TabIndex = 0;
            this.labelHourlyRate.Text = "Часовая тарифная ставка";
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Location = new System.Drawing.Point(14, 40);
            this.labelHour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(147, 13);
            this.labelHour.TabIndex = 1;
            this.labelHour.Text = "Кол-во отработанных часов";
            // 
            // textBoxHourlyRate
            // 
            this.textBoxHourlyRate.Location = new System.Drawing.Point(159, 13);
            this.textBoxHourlyRate.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHourlyRate.Name = "textBoxHourlyRate";
            this.textBoxHourlyRate.Size = new System.Drawing.Size(102, 20);
            this.textBoxHourlyRate.TabIndex = 2;
            // 
            // textBoxHour
            // 
            this.textBoxHour.Location = new System.Drawing.Point(228, 40);
            this.textBoxHour.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHour.Name = "textBoxHour";
            this.textBoxHour.Size = new System.Drawing.Size(33, 20);
            this.textBoxHour.TabIndex = 3;
            // 
            // SalaryHourlyRateUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 70);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.labelHourlyRate);
            this.Controls.Add(this.textBoxHour);
            this.Controls.Add(this.textBoxHourlyRate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SalaryHourlyRateUserControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelHourlyRate;
        private Label labelHour;
        private TextBox textBoxHourlyRate;
        private TextBox textBoxHour;
    }
}