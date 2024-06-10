using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void ВuttonAdd_Click(object sender, EventArgs e)
        {
            AddSalary addSalary = new AddSalary();
            addSalary.ShowDialog();
        }

        private void ВuttonFilter_Click(object sender, EventArgs e)
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

        private void ВuttonRandomSalary_Click(object sender, EventArgs e)
        {
            _salaryList.Add(RandomSalary.GetRandomSalary());
        }

        private void ВuttonCleanList_Click(object sender, EventArgs e)
        {
            _salaryList.Clear();
        }

        private void ВuttonDelete_Click(object sender, EventArgs e)
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

        private void ВuttonResetFilter_Click(object sender, EventArgs e)
        {
            CreateTable(_salaryList, dataGridViewSpace);
        }

        /// <summary>
        /// Сохранение списка в файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_salaryList.Count == 0)
            {
                MessageBox.Show("Отсутствуют данные для сохранения.",
                    "Данные не сохранены",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Файлы (*.zp)|*.zp|Все файлы (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveFileDialog.FileName.ToString();
                using (FileStream file = File.Create(path))
                {
                    _serializer.Serialize(file, _salaryList);
                }
                MessageBox.Show("Файл успешно сохранён.",
                    "Сохранение завершено",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Открытие файла со списком.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Файлы (*.zp)|*.zp|Все файлы (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            var path = openFileDialog.FileName.ToString();
            try
            {
                using (var file = new StreamReader(path))
                {
                    _salaryList = (BindingList<SalaryBase>)
                        _serializer.Deserialize(file);
                }

                dataGridViewSpace.DataSource = _salaryList;
                dataGridViewSpace.CurrentCell = null;
                MessageBox.Show("Файл успешно загружен.",
                    "Загрузка завершена",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось загрузить файл.\n" +
                    "Файл повреждён или не соответствует формату.",
                    "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
