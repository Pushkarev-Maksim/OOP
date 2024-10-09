using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Model;

namespace View
{
    //TODO: XML
    public partial class FilterSalary : Form
    {
        /// <summary>
        /// Исходный список транспорта.
        /// </summary>
        private BindingList<SalaryBase> _salaryList;

        /// <summary>
        /// Отфильтрованный список транспорта.
        /// </summary>
        private BindingList<SalaryBase> _filteredSalaryList;

        /// <summary>
        /// Событие на фильтрацию списка.
        /// </summary>
        public EventHandler SalaryFiltered;

        //TODO: XML
        public FilterSalary(BindingList<SalaryBase> salaryList)
        {
            InitializeComponent();
            _salaryList = salaryList;
            BackColor = Color.AliceBlue;
            StartPosition = FormStartPosition.CenterScreen;
            textBoxSalary.Enabled = false;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DeactivateElements();

            checkBoxSalaryHourlyRate.CheckedChanged += ActivateElements;
            checkBoxSalaryMonthly.CheckedChanged += ActivateElements;
            checkBoxSalaryTariffRate.CheckedChanged += ActivateElements;
            checkBoxInput.CheckedChanged += ActivateSalaryBox;
        }

        /// <summary>
        /// Деактивирует элементы управления на форме.
        /// </summary>
        private void DeactivateElements()
        {
            checkBoxInput.Enabled = false;
            textBoxSalary.Enabled = false;
        }

        /// <summary>
        /// Активирует или деактивирует элементы управления
        /// в зависимости от состояния чекбоксов типа фигуры.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект <see cref="EventArgs"/>,
        /// содержащий данные события.</param>
        private void ActivateElements(object sender, EventArgs e)
        {
            bool activate = checkBoxSalaryHourlyRate.Checked
                || checkBoxSalaryMonthly.Checked
                || checkBoxSalaryTariffRate.Checked;

            checkBoxInput.Enabled = activate;
        }

        private void ActivateSalaryBox(object sender, EventArgs e)
        {
            textBoxSalary.Enabled = checkBoxInput.Checked;
        }

        /// <summary>
        /// Активация поля ввода зарплаты для поиска.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void СheckBoxInput_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInput.Checked)
            {
                textBoxSalary.Enabled = true;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            _filteredSalaryList = new BindingList<SalaryBase>();

            if (checkBoxSalaryHourlyRate.Checked)
            {
                FilterByType(_salaryList,
                    _filteredSalaryList,
                    typeof(SalaryHourlyRate));
            }

            if (checkBoxSalaryMonthly.Checked)
            {
                FilterByType(_salaryList,
                    _filteredSalaryList,
                    typeof(SalaryMonthly));
            }

            if (checkBoxSalaryTariffRate.Checked)
            {
                FilterByType(_salaryList,
                    _filteredSalaryList,
                    typeof(SalaryTariffRate));
            }

            if (checkBoxInput.Checked)
            {
                if (!string.IsNullOrEmpty(textBoxSalary.Text))
                {
                    _filteredSalaryList = 
                        FilterByInitialValue(_filteredSalaryList,
                    Convert.ToDouble(textBoxSalary.Text));
                }
                else
                {
                    MessageBox.Show("Введите заработную плату.", "Предупреждение",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (_filteredSalaryList.Count == 0
                || _filteredSalaryList is null)
            {
                MessageBox.Show("Совпадений не найдено.", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SalaryFiltered?.Invoke(
                this, new SalaryFilterEvent(_filteredSalaryList));
        }

        private static void FilterByType(
            BindingList<SalaryBase> salaryList, 
            BindingList<SalaryBase> filteredSalaryList, 
            Type salaryType)
        {
            foreach (var salary in salaryList)
            {
                if (salaryType == salary.GetType())
                {
                    filteredSalaryList.Add(salary);
                }
            }
        }

        private static BindingList<SalaryBase> FilterByInitialValue(
            BindingList<SalaryBase> filteredSalaryList, double initialValue)
        {
            BindingList<SalaryBase> filteredList = new BindingList<SalaryBase>();
            foreach (var item in filteredSalaryList)
            {
                if (item.CalculateSalary == initialValue)
                {
                    filteredList.Add(item);
                }
            }

            return filteredList;
        }
    }
}