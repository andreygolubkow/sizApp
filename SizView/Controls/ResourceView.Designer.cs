namespace SizView.Controls
{
    partial class ResourceView
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.resourcesGridView = new System.Windows.Forms.DataGridView();
            this.resourceAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceAdapterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // resourcesGridView
            // 
            this.resourcesGridView.AllowUserToAddRows = false;
            this.resourcesGridView.AllowUserToDeleteRows = false;
            this.resourcesGridView.AutoGenerateColumns = false;
            this.resourcesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resourcesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resourcesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.resourcesGridView.DataSource = this.resourceAdapterBindingSource;
            this.resourcesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourcesGridView.Location = new System.Drawing.Point(0, 0);
            this.resourcesGridView.Name = "resourcesGridView";
            this.resourcesGridView.ReadOnly = true;
            this.resourcesGridView.RowHeadersVisible = false;
            this.resourcesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resourcesGridView.Size = new System.Drawing.Size(530, 238);
            this.resourcesGridView.TabIndex = 0;
            // 
            // resourceAdapterBindingSource
            // 
            this.resourceAdapterBindingSource.DataSource = typeof(Tools.ResourceAdapter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StartDateTime";
            this.dataGridViewTextBoxColumn2.HeaderText = "StartDateTime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EndDateTime";
            this.dataGridViewTextBoxColumn3.HeaderText = "EndDateTime";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // ResourceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resourcesGridView);
            this.Name = "ResourceView";
            this.Size = new System.Drawing.Size(530, 238);
            this.Load += new System.EventHandler(this.ResourceView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resourcesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceAdapterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView resourcesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource resourceAdapterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
