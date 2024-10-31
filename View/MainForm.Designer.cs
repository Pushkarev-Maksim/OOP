using System.Windows.Forms;
using View.Properties;

namespace View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this._groupBoxCalculator = new System.Windows.Forms.GroupBox();
            this._dataGridViewSpace = new System.Windows.Forms.DataGridView();
            this._buttonAdd = new System.Windows.Forms.Button();
            this._buttonDelete = new System.Windows.Forms.Button();
            this._buttonCleanList = new System.Windows.Forms.Button();
            this._buttonFilter = new System.Windows.Forms.Button();
            this._buttonResetFilter = new System.Windows.Forms.Button();
#if DEBUG
            this._buttonRandomSalary = new System.Windows.Forms.Button();
#endif            
            this._toolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this._saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._toolStrip = new System.Windows.Forms.ToolStrip();
            this._groupBoxCalculator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewSpace)).BeginInit();
            this._toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _groupBoxCalculator
            // 
            this._groupBoxCalculator.Controls.Add(this._dataGridViewSpace);
            this._groupBoxCalculator.Location = new System.Drawing.Point(23, 32);
            this._groupBoxCalculator.Margin = new System.Windows.Forms.Padding(2);
            this._groupBoxCalculator.Name = "groupBoxCalculator";
            this._groupBoxCalculator.Padding = new System.Windows.Forms.Padding(2);
            this._groupBoxCalculator.Size = new System.Drawing.Size(554, 235);
            this._groupBoxCalculator.TabIndex = 0;
            this._groupBoxCalculator.TabStop = false;
            // 
            // _dataGridViewSpace
            // 
            this._dataGridViewSpace.AllowUserToOrderColumns = true;
            this._dataGridViewSpace.AllowUserToResizeColumns = false;
            this._dataGridViewSpace.AllowUserToResizeRows = false;
            this._dataGridViewSpace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewSpace.Location = new System.Drawing.Point(4, 10);
            this._dataGridViewSpace.Margin = new System.Windows.Forms.Padding(2);
            this._dataGridViewSpace.Name = "dataGridViewSpace";
            this._dataGridViewSpace.RowHeadersWidth = 51;
            this._dataGridViewSpace.RowTemplate.Height = 25;
            this._dataGridViewSpace.Size = new System.Drawing.Size(545, 221);
            this._dataGridViewSpace.TabIndex = 1;
            // 
            // _buttonAdd
            // 
            this._buttonAdd.Location = new System.Drawing.Point(28, 281);
            this._buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this._buttonAdd.Name = "buttonAdd";
            this._buttonAdd.Size = new System.Drawing.Size(166, 25);
            this._buttonAdd.TabIndex = 2;
            this._buttonAdd.Text = "Добавить";
            this._buttonAdd.UseVisualStyleBackColor = true;
            this._buttonAdd.Click += new System.EventHandler(this.ClickВuttonAdd);
            // 
            // _buttonDelete
            // 
            this._buttonDelete.Location = new System.Drawing.Point(217, 281);
            this._buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this._buttonDelete.Name = "buttonDelete";
            this._buttonDelete.Size = new System.Drawing.Size(166, 25);
            this._buttonDelete.TabIndex = 3;
            this._buttonDelete.Text = "Удалить";
            this._buttonDelete.UseVisualStyleBackColor = true;
            this._buttonDelete.Click += new System.EventHandler(this.ClickВuttonDelete);
            // 
            // _buttonCleanList
            // 
            this._buttonCleanList.Location = new System.Drawing.Point(406, 281);
            this._buttonCleanList.Margin = new System.Windows.Forms.Padding(2);
            this._buttonCleanList.Name = "buttonCleanList";
            this._buttonCleanList.Size = new System.Drawing.Size(166, 25);
            this._buttonCleanList.TabIndex = 4;
            this._buttonCleanList.Text = "Очистить список";
            this._buttonCleanList.UseVisualStyleBackColor = true;
            this._buttonCleanList.Click += new System.EventHandler(this.ClickВuttonCleanList);
            // 
            // _buttonFilter
            // 
            this._buttonFilter.Location = new System.Drawing.Point(28, 314);
            this._buttonFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._buttonFilter.Name = "buttonFilter";
            this._buttonFilter.Size = new System.Drawing.Size(166, 25);
            this._buttonFilter.TabIndex = 5;
            this._buttonFilter.Text = "Фильтр";
            this._buttonFilter.UseVisualStyleBackColor = true;
            this._buttonFilter.Click += new System.EventHandler(this.ClickВuttonFilter);
            // 
            // _buttonResetFilter
            // 
            this._buttonResetFilter.Location = new System.Drawing.Point(217, 314);
            this._buttonResetFilter.Margin = new System.Windows.Forms.Padding(2);
            this._buttonResetFilter.Name = "buttonResetFilter";
            this._buttonResetFilter.Size = new System.Drawing.Size(166, 25);
            this._buttonResetFilter.TabIndex = 6;
            this._buttonResetFilter.Text = "Сбросить фильтр";
            this._buttonResetFilter.UseVisualStyleBackColor = true;
            this._buttonResetFilter.Click += new System.EventHandler(this.ClickВuttonResetFilter);
#if DEBUG        
            // 
            // _buttonRandomSalary
            // 
            this._buttonRandomSalary.Location = new System.Drawing.Point(406, 314);
            this._buttonRandomSalary.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._buttonRandomSalary.Name = "buttonRandomSalary";
            this._buttonRandomSalary.Size = new System.Drawing.Size(166, 25);
            this._buttonRandomSalary.TabIndex = 7;
            this._buttonRandomSalary.Text = "Случайная зарплата";
            this._buttonRandomSalary.UseVisualStyleBackColor = true;
            this._buttonRandomSalary.Click += new System.EventHandler(this.ClickВuttonRandomSalary);
#endif            
            // 
            // _toolStripDropDownButton
            // 
            this._toolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._toolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._saveToolStripMenuItem,
            this._openToolStripMenuItem});
            this._toolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolStripDropDownButton.Name = "toolStripDropDownButton";
            this._toolStripDropDownButton.Size = new System.Drawing.Size(59, 24);
            this._toolStripDropDownButton.Text = "Файл";
            // 
            // _saveToolStripMenuItem
            // 
            this._saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this._saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this._saveToolStripMenuItem.Text = "Сохранить";
            this._saveToolStripMenuItem.Click += new System.EventHandler(this.ClickSaveToolStripMenuItem);
            // 
            // _openToolStripMenuItem
            // 
            this._openToolStripMenuItem.Name = "openToolStripMenuItem";
            this._openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this._openToolStripMenuItem.Text = "Загрузить";
            this._openToolStripMenuItem.Click += new System.EventHandler(this.ClickOpenToolStripMenuItem);
            // 
            // _toolStrip
            // 
            this._toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._toolStripDropDownButton});
            this._toolStrip.Location = new System.Drawing.Point(0, 0);
            this._toolStrip.Name = "toolStrip";
            this._toolStrip.Size = new System.Drawing.Size(601, 27);
            this._toolStrip.TabIndex = 8;
            this._toolStrip.Text = "toolStrip";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 366);
            this.Controls.Add(this._groupBoxCalculator);
            this.Controls.Add(this._buttonAdd);
            this.Controls.Add(this._buttonDelete);
            this.Controls.Add(this._buttonCleanList);
            this.Controls.Add(this._buttonFilter);
            this.Controls.Add(this._toolStrip);
            this.Controls.Add(this._buttonResetFilter);
#if DEBUG
            this.Controls.Add(this._buttonRandomSalary);
#endif            
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Калькулятор заработных плат";
            this.Load += new System.EventHandler(this.LoadMainForm);
            this._groupBoxCalculator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewSpace)).EndInit();
            this._toolStrip.ResumeLayout(false);
            this._toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox _groupBoxCalculator;
        private DataGridView _dataGridViewSpace;
        private Button _buttonAdd;
        private Button _buttonDelete;
        private Button _buttonCleanList;
        private Button _buttonFilter;        
        private Button _buttonResetFilter;
#if DEBUG
        private Button _buttonRandomSalary;
#endif
        private ToolStripDropDownButton _toolStripDropDownButton;
        private ToolStripMenuItem _saveToolStripMenuItem;
        private ToolStripMenuItem _openToolStripMenuItem;
        private ToolStrip _toolStrip;
    }
}