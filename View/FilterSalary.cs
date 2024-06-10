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
    public partial class FilterSalary : Form
    {
        public FilterSalary()
        {
            InitializeComponent();
            BackColor = Color.AliceBlue;
            StartPosition = FormStartPosition.CenterScreen;
        }

        //private void buttonSearch_Click(object sender, EventArgs e)
        //{
            //_listSalaryFilter = new BindingList<SalaryBase>();

            //int count = 0;
            //if (!checkBoxHourlyWageRate.Checked
                //&& !checkBoxWageRate.Checked
                //&& !checkBoxSalary.Checked
                //&& !checkBoxInput.Checked)
            //{
                //MessageBox.Show("Критерии для поиска не введены!",
                    //"Внимание", MessageBoxButtons.OK,
                    //MessageBoxIcon.Warning);
                //return;
            //}

            //foreach (SalaryBase figure in _listSalary)
            //{

                //switch (figure)
                //{
                    //case HourlyWageRate when checkBoxHourlyWageRate.Checked:
                    //case WageRate when checkBoxWageRate.Checked:
                    //case Salary when checkBoxSalary.Checked:
                        //{
                            //if (checkBoxInput.Checked)
                            //{
                                //if (figure.Wages == _wage)
                                //{
                                    //count++;
                                    //_listWagesFilter.Add(figure);
                                    //break;
                                //}
                                //break;
                            //}
                            //else
                            //{
                                //count++;
                                //_listWagesFilter.Add(figure);
                                //break;
                            //}
                        //}
                //}

                //if (!checkBoxHourlyWageRate.Checked
                    //&& !checkBoxWageRate.Checked
                    //&& !checkBoxSalary.Checked)
                //{
                    //if (checkBoxInput.Checked && figure.Wages == _wage)
                    //{
                        //count++;
                        //_listWagesFilter.Add(figure);
                    //}
                //}
            //}

            //WageListEventArgs eventArgs;

            //if (count > 0)
            //{
                //eventArgs = new WageListEventArgs(_listWagesFilter);
            //}
            //else
            //{
                //MessageBox.Show("Зарплат с такими параметрами не " +
                    //"существует", "Введите другие параметры",
                    //MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //eventArgs = new WageListEventArgs(_listWagesFilter);
                //return;
            //}

            //WagesFiltered?.Invoke(this, eventArgs);
            //Close();
        //}
    }
}
