namespace SizView.Controls
{
    partial class SizListControl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.issueRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueRecordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Surname,
            this.Name,
            this.MiddleName,
            this.Profession,
            this.StartDate,
            this.EndDate});
            this.dataGridView1.DataSource = this.issueRecordBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(572, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // issueRecordBindingSource
            // 
            this.issueRecordBindingSource.DataSource = typeof(Model.Project.IssueRecord);
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.Name = "Surname";
            // 
            // Name
            // 
            this.Name.HeaderText = "Имя";
            this.Name.Name = "Name";
            // 
            // MiddleName
            // 
            this.MiddleName.HeaderText = "Отчество";
            this.MiddleName.Name = "MiddleName";
            // 
            // Profession
            // 
            this.Profession.HeaderText = "Профессия";
            this.Profession.Name = "Profession";
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Дата начала использования";
            this.StartDate.Name = "StartDate";
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "Дата окончания срока";
            this.EndDate.Name = "EndDate";
            // 
            // SizListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "SizListControl";
            this.Size = new System.Drawing.Size(572, 251);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueRecordBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profession;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.BindingSource issueRecordBindingSource;
    }
}
