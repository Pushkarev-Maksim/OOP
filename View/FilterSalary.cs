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
        //TODO: XML
        public FilterSalary()
        {
            InitializeComponent();
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
    }
}
