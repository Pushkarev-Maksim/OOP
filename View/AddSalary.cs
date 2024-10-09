using Model;
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
        public EventHandler SalaryAdded;

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

        /// <summary>
        /// Кнопка добавить.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButtonClick(object sender, EventArgs e)
        {
            SalaryBase salaryBase = null;

            if (salaryHourlyRateUserControl.Visible)
            {
                salaryBase = new SalaryHourlyRate()
                {
                    HourlyRate = Convert.ToDouble(salaryHourlyRateUserControl.textBoxHourlyRate.Text),
                    Hours = Convert.ToInt32(salaryHourlyRateUserControl.textBoxHours.Text),
                };
            }

            if (salaryMonthlyUserControl.Visible)
            {
                salaryBase = new SalaryMonthly()
                {
                    FixedSalary = Convert.ToDouble(salaryMonthlyUserControl.textBoxFixedSalary.Text),
                    MonthlyWorkingDays = Convert.ToInt32(salaryMonthlyUserControl.textBoxMonthlyWorkingDays.Text),
                    ActualWorkedDays = Convert.ToInt32(salaryMonthlyUserControl.textBoxActualWorkedDays.Text),

                };
            }

            if (salaryTariffRateUserControl.Visible)
            {
                salaryBase = new SalaryTariffRate()
                {
                    TariffRate = Convert.ToDouble(salaryTariffRateUserControl.textBoxTariffRate.Text),
                    Days = Convert.ToInt32(salaryTariffRateUserControl.textBoxDays.Text),
                };
            }

            SalaryAdded?.Invoke(this, new SalaryAddedEvent(salaryBase));
        }
    }
}
