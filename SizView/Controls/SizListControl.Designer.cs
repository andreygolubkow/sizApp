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
            this.issueGridView = new System.Windows.Forms.DataGridView();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.issueGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // issueGridView
            // 
            this.issueGridView.AllowUserToAddRows = false;
            this.issueGridView.AllowUserToDeleteRows = false;
            this.issueGridView.AllowUserToResizeRows = false;
            this.issueGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.issueGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issueGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Surname,
            this.PersonName,
            this.MiddleName,
            this.Profession,
            this.StartDate,
            this.EndDate});
            this.issueGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issueGridView.Location = new System.Drawing.Point(0, 0);
            this.issueGridView.MultiSelect = false;
            this.issueGridView.Name = "issueGridView";
            this.issueGridView.ReadOnly = true;
            this.issueGridView.RowHeadersVisible = false;
            this.issueGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.issueGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.issueGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.issueGridView.Size = new System.Drawing.Size(572, 251);
            this.issueGridView.TabIndex = 0;
            this.issueGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IssueGridViewCellClick);
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // PersonName
            // 
            this.PersonName.HeaderText = "Имя";
            this.PersonName.Name = "PersonName";
            this.PersonName.ReadOnly = true;
            // 
            // MiddleName
            // 
            this.MiddleName.HeaderText = "Отчество";
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.ReadOnly = true;
            // 
            // Profession
            // 
            this.Profession.HeaderText = "Профессия";
            this.Profession.Name = "Profession";
            this.Profession.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Дата начала использования";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "Дата окончания срока";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // SizListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.issueGridView);
            this.Name = "SizListControl";
            this.Size = new System.Drawing.Size(572, 251);
            ((System.ComponentModel.ISupportInitialize)(this.issueGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView issueGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profession;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
    }
}
