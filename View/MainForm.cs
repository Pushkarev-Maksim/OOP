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
        /// Список отфильтрованных зарплат.
        /// </summary>
        private BindingList<SalaryBase> _listSalaryFilter = new BindingList<SalaryBase>();

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
        /// <param name="salary"></param>
        /// <param name="dataGridView"></param>
        public static void CreateTable(BindingList<SalaryBase> salary,
              DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
            var source = new BindingSource(salary, null);
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
        /// Загрузка формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            _salaryList = new BindingList<SalaryBase>();
            CreateTable(_salaryList, dataGridViewSpace);
        }

        private void buttonRandomSalary_Click(object sender, EventArgs e)
        {
            _salaryList.Add(RandomSalary.GetRandomSalary());
        }

        private void buttonCleanList_Click(object sender, EventArgs e)
        {
            _salaryList.Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewSpace.SelectedCells.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridViewSpace.SelectedRows)
                {
                    _salaryList.Remove(row.DataBoundItem as SalaryBase);
                    _listSalaryFilter.Remove(row.DataBoundItem as SalaryBase);
                }
            }
        }

        private void buttonResetFilter_Click(object sender, EventArgs e)
        {
            CreateTable(_salaryList, dataGridViewSpace);
        }
    }
}
