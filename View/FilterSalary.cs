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
            textBoxSalary.Enabled = false;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        /// <summary>
        /// Лист зарплат
        /// </summary>
        private readonly BindingList<SalaryBase> _listSalary;

        /// <summary>
        /// Лист отфильтрованных зарплат
        /// </summary>
        private BindingList<SalaryBase> _listSalaryFilter;

        /// <summary>
        /// Обработчик события
        /// </summary>
        public EventHandler<EventArgs> SalaryFiltered;

        /// <summary>
        /// Зарплата
        /// </summary>
        private double _salary;
        
        private void checkBoxInput_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInput.Checked)
            {
                textBoxSalary.Enabled = true;
            }
        }
    }
}
