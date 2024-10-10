using Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    //TODO: XML +
    /// <summary>
    /// Класс AddSalary.
    /// </summary>
    public partial class AddSalary : Form
    {
        /// <summary>
        /// Поле для обработки события добавления.
        /// </summary>
        public EventHandler SalaryAdded;

        //TODO: XML +
        /// <summary>
        /// Конструктор AddSalary.
        /// </summary>
        public AddSalary()
        {
            InitializeComponent();
            BackColor = Color.AliceBlue;
            StartPosition = FormStartPosition.CenterScreen;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;

            salaryHourlyRateUserControl.textBoxHourlyRate.Tag = "double";
            salaryHourlyRateUserControl.textBoxHours.Tag = "int";
            salaryMonthlyUserControl.textBoxFixedSalary.Tag = "double";
            salaryMonthlyUserControl.textBoxMonthlyWorkingDays.Tag = "int";
            salaryMonthlyUserControl.textBoxActualWorkedDays.Tag = "int";
            salaryTariffRateUserControl.textBoxTariffRate.Tag = "double";
            salaryTariffRateUserControl.textBoxDays.Tag = "int";

            salaryHourlyRateUserControl.textBoxHourlyRate.KeyPress += new
                KeyPressEventHandler(TextBoxKeyPress);

            salaryHourlyRateUserControl.textBoxHours.KeyPress += new
                KeyPressEventHandler(TextBoxKeyPress);

            salaryMonthlyUserControl.textBoxFixedSalary.KeyPress += new
                KeyPressEventHandler(TextBoxKeyPress);

            salaryMonthlyUserControl.textBoxMonthlyWorkingDays.KeyPress += new
                KeyPressEventHandler(TextBoxKeyPress);

            salaryMonthlyUserControl.textBoxActualWorkedDays.KeyPress += new
                KeyPressEventHandler(TextBoxKeyPress);
            
            salaryTariffRateUserControl.textBoxTariffRate.KeyPress += new
                KeyPressEventHandler(TextBoxKeyPress);
            
            salaryTariffRateUserControl.textBoxDays.KeyPress += new
                KeyPressEventHandler(TextBoxKeyPress);
        }

        /// <summary>
        /// Загрузка формы часовой тарифной ставки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalaryHourlyRate_CheckedChanged(object sender, EventArgs e)
        {
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
            try
            {
                SalaryBase salaryBase = null;

                if (salaryHourlyRateUserControl.Visible)
                {
                    salaryBase = new SalaryHourlyRate()
                    {
                        HourlyRate = Convert.ToDouble(
                            salaryHourlyRateUserControl.textBoxHourlyRate.Text),
                        Hours = Convert.ToInt32(
                            salaryHourlyRateUserControl.textBoxHours.Text),
                    };
                }

                if (salaryMonthlyUserControl.Visible)
                {
                    salaryBase = new SalaryMonthly()
                    {
                        FixedSalary = Convert.ToDouble(
                            salaryMonthlyUserControl.textBoxFixedSalary.Text),
                        MonthlyWorkingDays = Convert.ToInt32(
                            salaryMonthlyUserControl.textBoxMonthlyWorkingDays.Text),
                        ActualWorkedDays = Convert.ToInt32(
                            salaryMonthlyUserControl.textBoxActualWorkedDays.Text),

                    };
                }

                if (salaryTariffRateUserControl.Visible)
                {
                    salaryBase = new SalaryTariffRate()
                    {
                        TariffRate = Convert.ToDouble(
                            salaryTariffRateUserControl.textBoxTariffRate.Text),
                        Days = Convert.ToInt32(
                            salaryTariffRateUserControl.textBoxDays.Text),
                    };
                }

                SalaryAdded?.Invoke(this, new SalaryAddedEvent(salaryBase));
            }

            catch
            {
                MessageBox.Show("Введите данные.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Проверка данных вводимых в textBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            string dataType = textBox.Tag as string;

            if (dataType == "int")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else if (dataType == "double")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                {
                    e.Handled = true;
                }

                if (e.KeyChar == ',' && textBox.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar == '0' && string.IsNullOrEmpty(textBox.Text.Trim('0')))
            {
                e.Handled = true;
            }
        }
    }
}