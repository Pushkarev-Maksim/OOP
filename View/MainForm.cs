using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Model;

namespace View
{
    /// <summary>
    /// Класс основной программы.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список зарплат.
        /// </summary>
        private BindingList<SalaryBase> _salaryList = 
            new BindingList<SalaryBase>();

        /// <summary>
        /// Список отфильтрованных зарплат.
        /// </summary>
        private BindingList<SalaryBase> _listSalaryFilter = 
            new BindingList<SalaryBase>();
         
        /// <summary>
        /// Для файлов.
        /// </summary>
        private readonly XmlSerializer _serializer =
            new XmlSerializer(typeof(BindingList<SalaryBase>));

        /// <summary>
        /// Поле для хранения состояния формы добавления.
        /// </summary>
        private bool _isAddFormOpen = false;

        /// <summary>
        /// Поле для хранения состояния формы фильтра.
        /// </summary>
        private bool _isFilterFormOpen = false;

        /// <summary>
        /// Поле для хранения состояния фильтрации.
        /// </summary>
        private bool _isFilter = false;

        /// <summary>
        /// Конструктор MainForm.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            BackColor = Color.AliceBlue;
            _dataGridViewSpace.BackgroundColor = Color.LightGray;
            StartPosition = FormStartPosition.CenterScreen;
            UpdatingStatusButtons();
        }

        /// <summary>
        /// Переход в форму добавления новой зарплаты.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void ClickВuttonAdd(object sender, EventArgs e)
        {
            AddSalary addSalary = new AddSalary();
            addSalary.SalaryAdded += AddedSalary;
            _isAddFormOpen = true;
            UpdatingStatusButtons();
            addSalary.FormClosed += (s, args) =>
            {
                _isAddFormOpen = false;
                UpdatingStatusButtons();
            };

            addSalary.Show();
        }

        /// <summary>
        /// Переход в форму фильтрации.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void ClickВuttonFilter(object sender, EventArgs e)
        {
            FilterSalary filterSalary = new FilterSalary(_salaryList);
            filterSalary.SalaryFiltered += FilteredSalary;
            _isFilterFormOpen = true;
            UpdatingStatusButtons();
            filterSalary.FormClosed += (s, args) =>
            {
                _isFilterFormOpen = false;
                UpdatingStatusButtons();
            };

            filterSalary.Show();
        }

        /// <summary>
        /// Создание таблицы DataGrid.
        /// </summary>
        /// <param name="salary">Список зарплат.</param>
        /// <param name="dataGridView">Сетка.</param>
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
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void LoadMainForm(object sender, EventArgs e)
        {
            _salaryList = new BindingList<SalaryBase>();
            CreateTable(_salaryList, _dataGridViewSpace);
        }

        /// <summary>
        /// Добавление в список случайной зарплаты.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void ClickВuttonRandomSalary(object sender, EventArgs e)
        {
            _salaryList.Add(RandomSalary.GetRandomSalary());
        }

        /// <summary>
        /// Очистить список.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void ClickВuttonCleanList(object sender, EventArgs e)
        {
            _dataGridViewSpace.ClearSelection();
            foreach (DataGridViewRow row in _dataGridViewSpace.Rows)
            {
                row.Selected = true;
            }
            foreach (DataGridViewRow row in
                    _dataGridViewSpace.SelectedRows)
            {
                if (row.DataBoundItem is SalaryBase salary)
                {
                    _salaryList.Remove(salary);
                    if (_listSalaryFilter != null 
                        && _listSalaryFilter.Count > 0)
                    {
                        _listSalaryFilter.Remove(salary);
                    }
                }
            }
        }

        /// <summary>
        /// Удаление позиции.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void ClickВuttonDelete(object sender, EventArgs e)
        {
            if (_dataGridViewSpace.SelectedCells.Count != 0)
            {
                foreach (DataGridViewRow row in
                    _dataGridViewSpace.SelectedRows)
                {
                    if (row.DataBoundItem is SalaryBase salary)
                    {
                        _salaryList.Remove(salary);
                        if (_listSalaryFilter != null 
                            && _listSalaryFilter.Count > 0)
                        {
                            _listSalaryFilter.Remove(salary);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Сброс наcтроек фильтра.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void ClickВuttonResetFilter(object sender, EventArgs e)
        {
            CreateTable(_salaryList, _dataGridViewSpace);
            _isFilter = false;
            UpdatingStatusButtons();
        }

        /// <summary>
        /// Сохранение списка в файл.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void ClickSaveToolStripMenuItem(object sender, EventArgs e)
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
        /// <param name="sender">Данные.</param>
        /// <param name="e">Данные о событие.</param>
        private void ClickOpenToolStripMenuItem(object sender, EventArgs e)
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

                _dataGridViewSpace.DataSource = _salaryList;
                _dataGridViewSpace.CurrentCell = null;
                MessageBox.Show("Файл успешно загружен.",
                    "Загрузка завершена",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить файл.\n" +
                    "Файл повреждён или не соответствует формату.",
                    $"Ошибка:  {ex.Message}",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Метод обновления состояний кнопок.
        /// </summary>
        private void UpdatingStatusButtons()
        {
            _buttonAdd.Enabled = !_isFilterFormOpen &&
                !_isFilter && !_isAddFormOpen;

            _buttonFilter.Enabled = !_isAddFormOpen &&
                !_isFilterFormOpen;

            _toolStripDropDownButton.Enabled = !_isFilter;
            _buttonRandomSalary.Enabled = _toolStripDropDownButton.Enabled;
        }

        /// <summary>
        /// Обработчик добавления данных в лист.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="salaryBase">Объект класса SalaryBase.</param>
        private void AddedSalary(object sender, EventArgs salaryBase)
        {
            SalaryAddedEvent addedEventArgs =
                salaryBase as SalaryAddedEvent;

            _salaryList.Add(addedEventArgs?.SalaryBase);
        }

        /// <summary>
        /// Обработчик фильтрации данных.
        /// </summary>
        /// <param name="sender">Данные.</param>
        /// <param name="salaryList">Список зарплат.</param>
        private void FilteredSalary(object sender, EventArgs salaryList)
        {
            SalaryFilterEvent filterEventArgs =
                 salaryList as SalaryFilterEvent;
            _listSalaryFilter = filterEventArgs?.FilteredSalaryList;
            _isFilter = true;
            UpdatingStatusButtons();
            CreateTable(_listSalaryFilter, _dataGridViewSpace);
        }
    }
}