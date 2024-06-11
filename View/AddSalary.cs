using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    //TODO: XML
    public partial class AddSalary : Form
    {
        //TODO: XML
        public AddSalary()
        {
            InitializeComponent();
            BackColor = Color.AliceBlue;
            StartPosition = FormStartPosition.CenterScreen;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        /// <summary>
        /// Загрузка формы часовой тарифной ставки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalaryHourlyRate_CheckedChanged(object sender, EventArgs e)
        {
            //TODO: refactor
            var currentRadioButton = (RadioButton)sender;

            salaryHourlyRateUserControl.Visible = true;
            salaryMonthlyUserControl.Visible = false;
            salaryTariffRateUserControl.Visible = false;
        }

        /// <summary>
        /// Загрузка формы оклада за месяц.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalaryMonthly_CheckedChanged(object sender, EventArgs e)
        {
            salaryHourlyRateUserControl.Visible = false;
            salaryMonthlyUserControl.Visible = true;
            salaryTariffRateUserControl.Visible = false;
        }

        /// <summary>
        /// Загрузка формы тарифной ставки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalaryTariffRate_CheckedChanged(object sender, EventArgs e)
        {
            salaryHourlyRateUserControl.Visible = false;
            salaryMonthlyUserControl.Visible = false;
            salaryTariffRateUserControl.Visible = true;
        }
        
        /// <summary>
        /// Кнопка закрыть.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
