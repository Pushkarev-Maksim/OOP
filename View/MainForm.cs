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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            BackColor = Color.AliceBlue;
            dataGridViewSpace.BackgroundColor = Color.LightGray;
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxCalculator_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewSpace_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
