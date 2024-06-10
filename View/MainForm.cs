using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Model;

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

        /// <summary>
        /// Список зарплат.
        /// </summary>
        private BindingList<SalaryBase> _salaryList = new BindingList<SalaryBase>();

        /// <summary>
        /// Для файлов.
        /// </summary>
        private readonly XmlSerializer _serializer =
            new XmlSerializer(typeof(BindingList<SalaryBase>));

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddSalary addSalary = new AddSalary();

            addSalary.ShowDialog();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            FilterSalary filterSalary = new FilterSalary();

            filterSalary.ShowDialog();
        }

        /// <summary>
        /// Создание таблицы DataGrid.
        /// </summary>
        /// <param name="wages"></param>
        /// <param name="dataGridView"></param>
        public static void CreateTable(BindingList<SalaryBase> wages,
              DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
            var source = new BindingSource(wages, null);
            dataGridView.DataSource = source;

            dataGridView.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DefaultCellStyle.WrapMode =
                DataGridViewTriState.True;
            dataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// Загрузка формы 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            _salaryList = new BindingList<SalaryBase>();
            CreateTable(_salaryList, dataGridViewSpace);
        }
    }
}
