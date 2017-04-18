namespace SizView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.issueRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resourcesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueRecordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.viewMenuItem,
            this.controlMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(680, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileMenuItem.Text = "Файл";
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInfoMenuItem});
            this.viewMenuItem.Name = "viewMenuItem";
            this.viewMenuItem.Size = new System.Drawing.Size(39, 20);
            this.viewMenuItem.Text = "Вид";
            // 
            // showInfoMenuItem
            // 
            this.showInfoMenuItem.Name = "showInfoMenuItem";
            this.showInfoMenuItem.Size = new System.Drawing.Size(203, 22);
            this.showInfoMenuItem.Text = "Показать информацию";
            // 
            // controlMenuItem
            // 
            this.controlMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employesMenuItem,
            this.informationMenuItem});
            this.controlMenuItem.Name = "controlMenuItem";
            this.controlMenuItem.Size = new System.Drawing.Size(85, 20);
            this.controlMenuItem.Text = "Управление";
            // 
            // employesMenuItem
            // 
            this.employesMenuItem.Name = "employesMenuItem";
            this.employesMenuItem.Size = new System.Drawing.Size(148, 22);
            this.employesMenuItem.Text = "Работники";
            this.employesMenuItem.Click += new System.EventHandler(this.employesMenuItem_Click);
            // 
            // informationMenuItem
            // 
            this.informationMenuItem.Name = "informationMenuItem";
            this.informationMenuItem.Size = new System.Drawing.Size(148, 22);
            this.informationMenuItem.Text = "Информация";
            this.informationMenuItem.Click += new System.EventHandler(this.informationMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeDataGridViewTextBoxColumn,
            this.professionsDataGridViewTextBoxColumn,
            this.resourcesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.issueRecordBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(656, 283);
            this.dataGridView1.TabIndex = 1;
            // 
            // issueRecordBindingSource
            // 
            this.issueRecordBindingSource.DataSource = typeof(Model.Project.IssueRecord);
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Employee";
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            // 
            // professionsDataGridViewTextBoxColumn
            // 
            this.professionsDataGridViewTextBoxColumn.DataPropertyName = "Professions";
            this.professionsDataGridViewTextBoxColumn.HeaderText = "Professions";
            this.professionsDataGridViewTextBoxColumn.Name = "professionsDataGridViewTextBoxColumn";
            // 
            // resourcesDataGridViewTextBoxColumn
            // 
            this.resourcesDataGridViewTextBoxColumn.DataPropertyName = "Resources";
            this.resourcesDataGridViewTextBoxColumn.HeaderText = "Resources";
            this.resourcesDataGridViewTextBoxColumn.Name = "resourcesDataGridViewTextBoxColumn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 322);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "СИЗ Контроль";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueRecordBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showInfoMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem controlMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resourcesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource issueRecordBindingSource;
    }
}

