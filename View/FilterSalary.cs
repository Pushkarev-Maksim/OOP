using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            bool checkClick = checkBoxSalaryHourlyRate.Checked
               || checkBoxSalaryMonthly.Checked
               || checkBoxSalaryTariffRate.Checked
               || checkBoxInput.Checked;

            if (checkClick)
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

                CheckedData();

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
            else
            {
                MessageBox.Show("Заполните критерии поиска.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void CheckedData()
        {
            BindingList<SalaryBase> salaryList = new BindingList<SalaryBase>();

            bool statusCheckBox = checkBoxSalaryHourlyRate.Checked
                || checkBoxSalaryMonthly.Checked
                || checkBoxSalaryTariffRate.Checked;

            if (statusCheckBox)
            {
                salaryList = new BindingList<SalaryBase>(_filteredSalaryList);
            }
            else
            {
                salaryList = new BindingList<SalaryBase>(_salaryList);
            }

            // if (checkBoxInitialValue.Checked)
            // {
            //     if (!string.IsNullOrEmpty(textBoxInitialValue.Text))
            //     {
            //         FilterByInitialValue(motionList,
            //         Convert.ToDouble(textBoxInitialValue.Text));
            //         _filteredMotionList = motionList;
            //     }
            //     else
            //     {
            //         MessageBox.Show("Введите начальную координату.", "Предупреждение",
            //             MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //     }
            // }
        }


        //_filteredSalaryList = _salaryList;
        //
        //_filteredSalaryList.Add(_salaryList[1]);
        //
        //SalaryFiltered?.Invoke(this, new SalaryFilterEvent(_filteredSalaryList));
    }
}
