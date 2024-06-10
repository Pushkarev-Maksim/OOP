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
    public partial class AddSalary : Form
    {
        public AddSalary()
        {
            InitializeComponent();
            BackColor = Color.AliceBlue;
            StartPosition = FormStartPosition.CenterScreen;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void salaryHourlyRate_CheckedChanged(object sender, EventArgs e)
        {
            salaryHourlyRateUserControl.Visible = true;
            salaryMonthlyUserControl.Visible = false;
            salaryTariffRateUserControl.Visible = false;
        }

        private void salaryMonthly_CheckedChanged(object sender, EventArgs e)
        {
            salaryHourlyRateUserControl.Visible = false;
            salaryMonthlyUserControl.Visible = true;
            salaryTariffRateUserControl.Visible = false;
        }

        private void salaryTariffRate_CheckedChanged(object sender, EventArgs e)
        {
            salaryHourlyRateUserControl.Visible = false;
            salaryMonthlyUserControl.Visible = false;
            salaryTariffRateUserControl.Visible = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
