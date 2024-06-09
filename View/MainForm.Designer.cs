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
            this.groupBoxCalculator = new System.Windows.Forms.GroupBox();
            this.dataGridViewSpace = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCleanList = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonResetFilter = new System.Windows.Forms.Button();
            this.buttonRandomSalary = new System.Windows.Forms.Button();
            this.toolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.groupBoxCalculator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpace)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCalculator
            // 
            this.groupBoxCalculator.Controls.Add(this.dataGridViewSpace);
            this.groupBoxCalculator.Location = new System.Drawing.Point(23, 32);
            this.groupBoxCalculator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCalculator.Name = "groupBoxCalculator";
            this.groupBoxCalculator.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCalculator.Size = new System.Drawing.Size(554, 235);
            this.groupBoxCalculator.TabIndex = 0;
            this.groupBoxCalculator.TabStop = false;
            this.groupBoxCalculator.Enter += new System.EventHandler(this.groupBoxCalculator_Enter);
            // 
            // dataGridViewSpace
            // 
            this.dataGridViewSpace.AllowUserToOrderColumns = true;
            this.dataGridViewSpace.AllowUserToResizeColumns = false;
            this.dataGridViewSpace.AllowUserToResizeRows = false;
            this.dataGridViewSpace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpace.Location = new System.Drawing.Point(4, 10);
            this.dataGridViewSpace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewSpace.Name = "dataGridViewSpace";
            this.dataGridViewSpace.RowHeadersWidth = 51;
            this.dataGridViewSpace.RowTemplate.Height = 25;
            this.dataGridViewSpace.Size = new System.Drawing.Size(545, 221);
            this.dataGridViewSpace.TabIndex = 1;
            this.dataGridViewSpace.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSpace_CellContentClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(28, 281);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(166, 25);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(217, 281);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(166, 25);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonCleanList
            // 
            this.buttonCleanList.Location = new System.Drawing.Point(406, 281);
            this.buttonCleanList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCleanList.Name = "buttonCleanList";
            this.buttonCleanList.Size = new System.Drawing.Size(166, 25);
            this.buttonCleanList.TabIndex = 4;
            this.buttonCleanList.Text = "Очистить список";
            this.buttonCleanList.UseVisualStyleBackColor = true;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(28, 314);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(166, 25);
            this.buttonFilter.TabIndex = 5;
            this.buttonFilter.Text = "Фильтр";
            this.buttonFilter.UseVisualStyleBackColor = true;
            // 
            // buttonResetFilter
            // 
            this.buttonResetFilter.Location = new System.Drawing.Point(217, 314);
            this.buttonResetFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonResetFilter.Name = "buttonResetFilter";
            this.buttonResetFilter.Size = new System.Drawing.Size(166, 25);
            this.buttonResetFilter.TabIndex = 6;
            this.buttonResetFilter.Text = "Сбросить фильтр";
            this.buttonResetFilter.UseVisualStyleBackColor = true;
            // 
            // buttonRandomSalary
            // 
            this.buttonRandomSalary.Location = new System.Drawing.Point(406, 314);
            this.buttonRandomSalary.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonRandomSalary.Name = "buttonRandomSalary";
            this.buttonRandomSalary.Size = new System.Drawing.Size(166, 25);
            this.buttonRandomSalary.TabIndex = 7;
            this.buttonRandomSalary.Text = "Случайная зарплата";
            this.buttonRandomSalary.UseVisualStyleBackColor = true;
            // 
            // toolStripDropDownButton
            // 
            this.toolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.toolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton.Name = "toolStripDropDownButton";
            this.toolStripDropDownButton.Size = new System.Drawing.Size(49, 22);
            this.toolStripDropDownButton.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.openToolStripMenuItem.Text = "Загрузить";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(601, 25);
            this.toolStrip.TabIndex = 8;
            this.toolStrip.Text = "toolStrip";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 366);
            this.Controls.Add(this.groupBoxCalculator);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCleanList);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.buttonResetFilter);
            this.Controls.Add(this.buttonRandomSalary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Калькулятор заработных плат";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxCalculator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpace)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBoxCalculator;
        private DataGridView dataGridViewSpace;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonCleanList;
        private Button buttonFilter;
        private Button buttonResetFilter;
        private Button buttonRandomSalary;           
        private ToolStripDropDownButton toolStripDropDownButton;
        private ToolStrip toolStrip;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
    }
}