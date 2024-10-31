using Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Класс для добавления зарплаты.
    /// </summary>
    public partial class AddSalary : Form
    {
        /// <summary>
        /// Поле для обработки события добавления.
        /// </summary>
        public EventHandler SalaryAdded;

        /// <summary>
        /// Конструктор AddSalary.
        /// </summary>
        public AddSalary()
        {
            InitializeComponent();
            BackColor = Color.AliceBlue;
            StartPosition = FormStartPosition.CenterScreen;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;

            _salaryHourlyRateUserControl._textBoxHourlyRate.Tag = typeof(double);
            _salaryHourlyRateUserControl._textBoxHours.Tag = typeof(int);
            _salaryMonthlyUserControl._textBoxFixedSalary.Tag = typeof(double);
            _salaryMonthlyUserControl._textBoxMonthlyWorkingDays.Tag = typeof(int);
            _salaryMonthlyUserControl._textBoxActualWorkedDays.Tag = typeof(int);
            _salaryTariffRateUserControl._textBoxTariffRate.Tag = typeof(double);
            _salaryTariffRateUserControl._textBoxDays.Tag = typeof(int);

            _salaryHourlyRateUserControl._textBoxHourlyRate.KeyPress += new
                KeyPressEventHandler(TextBoxHandler.TextBoxKeyPress);

            _salaryHourlyRateUserControl._textBoxHours.KeyPress += new
                KeyPressEventHandler(TextBoxHandler.TextBoxKeyPress);

            _salaryMonthlyUserControl._textBoxFixedSalary.KeyPress += new
                KeyPressEventHandler(TextBoxHandler.TextBoxKeyPress);

            _salaryMonthlyUserControl._textBoxMonthlyWorkingDays.KeyPress += new
                KeyPressEventHandler(TextBoxHandler.TextBoxKeyPress);

            _salaryMonthlyUserControl._textBoxActualWorkedDays.KeyPress += new
                KeyPressEventHandler(TextBoxHandler.TextBoxKeyPress);
            
            _salaryTariffRateUserControl._textBoxTariffRate.KeyPress += new
                KeyPressEventHandler(TextBoxHandler.TextBoxKeyPress);
            
            _salaryTariffRateUserControl._textBoxDays.KeyPress += new
                KeyPressEventHandler(TextBoxHandler.TextBoxKeyPress);
        }

        /// <summary>
        /// Загрузка формы часовой тарифной ставки.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void ChangeSalaryHourlyRate(object sender, EventArgs e)
        {
            _salaryHourlyRateUserControl.Visible = true;
            _salaryMonthlyUserControl.Visible = false;
            _salaryTariffRateUserControl.Visible = false;
        }

        /// <summary>
        /// Загрузка формы оклада за месяц.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void ChangeSalaryMonthly(object sender, EventArgs e)
        {
            _salaryHourlyRateUserControl.Visible = false;
            _salaryMonthlyUserControl.Visible = true;
            _salaryTariffRateUserControl.Visible = false;
        }

        /// <summary>
        /// Загрузка формы тарифной ставки.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void ChangeSalaryTariffRate(object sender, EventArgs e)
        {
            _salaryHourlyRateUserControl.Visible = false;
            _salaryMonthlyUserControl.Visible = false;
            _salaryTariffRateUserControl.Visible = true;
        }
        
        /// <summary>
        /// Кнопка закрыть.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void ClickButtonClose(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Кнопка добавить.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void ClickButtonAdd(object sender, EventArgs e)
        {
            try
            {
                SalaryBase salaryBase = null;

                if (_salaryHourlyRateUserControl.Visible)
                {
                    salaryBase = new SalaryHourlyRate()
                    {
                        HourlyRate = Convert.ToDouble(
                            _salaryHourlyRateUserControl._textBoxHourlyRate.Text),
                        Hours = Convert.ToInt32(
                            _salaryHourlyRateUserControl._textBoxHours.Text),
                    };
                }

                if (_salaryMonthlyUserControl.Visible)
                {
                    salaryBase = new SalaryMonthly()
                    {
                        FixedSalary = Convert.ToDouble(
                            _salaryMonthlyUserControl._textBoxFixedSalary.Text),
                        MonthlyWorkingDays = Convert.ToInt32(
                            _salaryMonthlyUserControl._textBoxMonthlyWorkingDays.Text),
                        ActualWorkedDays = Convert.ToInt32(
                            _salaryMonthlyUserControl._textBoxActualWorkedDays.Text),
                    };
                }

                if (_salaryTariffRateUserControl.Visible)
                {
                    salaryBase = new SalaryTariffRate()
                    {
                        TariffRate = Convert.ToDouble(
                            _salaryTariffRateUserControl._textBoxTariffRate.Text),
                        Days = Convert.ToInt32(
                            _salaryTariffRateUserControl._textBoxDays.Text),
                    };
                }

                SalaryAdded?.Invoke(this, new SalaryAddedEvent(salaryBase));
            }
            catch (ArgumentOutOfRangeException exeption)
            {
                MessageBox.Show($"{exeption.Message}", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Введите данные.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}