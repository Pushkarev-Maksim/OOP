using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Model;
using View;

namespace View
{
    /// <summary>
    /// Класс для настройки фильтрации.
    /// </summary>
    public partial class FilterSalary : Form
    {
        /// <summary>
        /// Исходный список транспорта.
        /// </summary>
        private readonly BindingList<SalaryBase> _salaryList;

        /// <summary>
        /// Отфильтрованный список транспорта.
        /// </summary>
        private BindingList<SalaryBase> _filteredSalaryList;

        /// <summary>
        /// Событие на фильтрацию списка.
        /// </summary>
        public EventHandler SalaryFiltered;

        /// <summary>
        /// Конструктор FilterSalary.
        /// </summary>
        /// <param name="salaryList">Список заработных плат
        /// для фильтрации.</param>
        public FilterSalary(BindingList<SalaryBase> salaryList)
        {
            InitializeComponent();
            _salaryList = salaryList;
            BackColor = Color.AliceBlue;
            StartPosition = FormStartPosition.CenterScreen;
            textBoxSalary.Enabled = false;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            
            textBoxSalary.Tag = "double";
            textBoxSalary.KeyPress += new
                KeyPressEventHandler(TextBoxHandler.TextBoxKeyPress);
            DeactivateElements();

            checkBoxSalaryHourlyRate.CheckedChanged += ActivateElements;
            checkBoxSalaryMonthly.CheckedChanged += ActivateElements;
            checkBoxSalaryTariffRate.CheckedChanged += ActivateElements;
            checkBoxInput.CheckedChanged += ActivateSalaryBox;
        }

        /// <summary>
        /// Деактивация элементов управления на форме.
        /// </summary>
        private void DeactivateElements()
        {
            checkBoxInput.Enabled = false;
            textBoxSalary.Enabled = false;
        }

        /// <summary>
        /// Активирация или деактивация элементов управления
        /// в зависимости от состояния чекбоксов типа ЗП.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void ActivateElements(object sender, EventArgs e)
        {
            bool activate = checkBoxSalaryHourlyRate.Checked
                || checkBoxSalaryMonthly.Checked
                || checkBoxSalaryTariffRate.Checked;

            checkBoxInput.Enabled = activate;
        }
        
        /// <summary>
        /// Активация поля ввода значения ЗП.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void ActivateSalaryBox(object sender, EventArgs e)
        {
            textBoxSalary.Enabled = checkBoxInput.Checked;
        }

        /// <summary>
        /// Активация поля ввода зарплаты для поиска.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void ActivateTextBox(object sender, EventArgs e)
        {
            if (checkBoxInput.Checked)
            {
                textBoxSalary.Enabled = true;
            }
        }

        /// <summary>
        /// Фильтрация списка.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void Filter(object sender, EventArgs e)
        {
            _filteredSalaryList = new BindingList<SalaryBase>();

            BindingList<SalaryBase> tempFilteredList = 
                new BindingList<SalaryBase>();

            if (checkBoxSalaryHourlyRate.Checked)
            {
                FilterByType(_salaryList, 
                    tempFilteredList, 
                    typeof(SalaryHourlyRate));
            }

            if (checkBoxSalaryMonthly.Checked)
            {
                FilterByType(_salaryList, 
                    tempFilteredList,
                    typeof(SalaryMonthly));
            }

            if (checkBoxSalaryTariffRate.Checked)
            {
                FilterByType(_salaryList,
                    tempFilteredList, 
                    typeof(SalaryTariffRate));
            }

            if (checkBoxInput.Checked)
            {
                if (!string.IsNullOrEmpty(textBoxSalary.Text))
                {
                    tempFilteredList = 
                        FilterBySalaryValue(tempFilteredList, 
                        Convert.ToDouble(textBoxSalary.Text));
                }
                else
                {
                    MessageBox.Show("Введите заработную плату.", "Предупреждение", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            foreach (var salary in _salaryList)
            {
                if (tempFilteredList.Contains(salary))
                {
                    _filteredSalaryList.Add(salary);
                }
            }

            if (_filteredSalaryList.Count == 0 
                || _filteredSalaryList is null)
            {
                MessageBox.Show("Совпадений не найдено.", "Информация", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SalaryFiltered?.Invoke(this, new SalaryFilterEvent(_filteredSalaryList));
        }

        /// <summary>
        /// Фильтрация списка по типу.
        /// </summary>
        /// <param name="salaryList">ист подлежащий фильтрации.</param>
        /// <param name="filteredSalaryList">Список, в который будут добавленны
        /// отфильтрованные значения.</param>
        /// <param name="salaryType">Тип отфильтрованных значений.</param>
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

        /// <summary>
        /// Фильтрация списка по значению ЗП.
        /// </summary>
        /// <param name="filteredSalaryList">Лист подлежащий фильтрации.</param>
        /// <param name="initialValue">Значение ЗП.</param>
        /// <returns>Отфильтрованный список.</returns>
        private static BindingList<SalaryBase> FilterBySalaryValue(
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