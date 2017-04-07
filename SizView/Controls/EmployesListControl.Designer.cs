namespace SizView.Controls
{
    partial class EmployesListControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.employesGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structuralUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfEmploymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateChangePositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.growthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clothingSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoeSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headgearSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gasmaskSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.respiratorSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gauntletsSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glovesSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEmployeeBindingSource)).BeginInit();
            this.searchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.employesGridView);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 427);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список работников";
            // 
            // employesGridView
            // 
            this.employesGridView.AllowUserToAddRows = false;
            this.employesGridView.AllowUserToDeleteRows = false;
            this.employesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employesGridView.AutoGenerateColumns = false;
            this.employesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.personnelNumberDataGridViewTextBoxColumn,
            this.structuralUnitDataGridViewTextBoxColumn,
            this.professionDataGridViewTextBoxColumn,
            this.dateOfEmploymentDataGridViewTextBoxColumn,
            this.dateChangePositionDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.growthDataGridViewTextBoxColumn,
            this.clothingSizeDataGridViewTextBoxColumn,
            this.shoeSizeDataGridViewTextBoxColumn,
            this.headgearSizeDataGridViewTextBoxColumn,
            this.gasmaskSizeDataGridViewTextBoxColumn,
            this.respiratorSizeDataGridViewTextBoxColumn,
            this.gauntletsSizeDataGridViewTextBoxColumn,
            this.glovesSizeDataGridViewTextBoxColumn});
            this.employesGridView.DataSource = this.iEmployeeBindingSource;
            this.employesGridView.Location = new System.Drawing.Point(6, 19);
            this.employesGridView.MultiSelect = false;
            this.employesGridView.Name = "employesGridView";
            this.employesGridView.ReadOnly = true;
            this.employesGridView.RowHeadersVisible = false;
            this.employesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employesGridView.Size = new System.Drawing.Size(530, 402);
            this.employesGridView.TabIndex = 0;
            this.employesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employesGridView_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 30F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Код";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personnelNumberDataGridViewTextBoxColumn
            // 
            this.personnelNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.personnelNumberDataGridViewTextBoxColumn.DataPropertyName = "PersonnelNumber";
            this.personnelNumberDataGridViewTextBoxColumn.HeaderText = "Табельный №";
            this.personnelNumberDataGridViewTextBoxColumn.Name = "personnelNumberDataGridViewTextBoxColumn";
            this.personnelNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // structuralUnitDataGridViewTextBoxColumn
            // 
            this.structuralUnitDataGridViewTextBoxColumn.DataPropertyName = "StructuralUnit";
            this.structuralUnitDataGridViewTextBoxColumn.HeaderText = "StructuralUnit";
            this.structuralUnitDataGridViewTextBoxColumn.Name = "structuralUnitDataGridViewTextBoxColumn";
            this.structuralUnitDataGridViewTextBoxColumn.ReadOnly = true;
            this.structuralUnitDataGridViewTextBoxColumn.Visible = false;
            // 
            // professionDataGridViewTextBoxColumn
            // 
            this.professionDataGridViewTextBoxColumn.DataPropertyName = "Profession";
            this.professionDataGridViewTextBoxColumn.HeaderText = "Profession";
            this.professionDataGridViewTextBoxColumn.Name = "professionDataGridViewTextBoxColumn";
            this.professionDataGridViewTextBoxColumn.ReadOnly = true;
            this.professionDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateOfEmploymentDataGridViewTextBoxColumn
            // 
            this.dateOfEmploymentDataGridViewTextBoxColumn.DataPropertyName = "DateOfEmployment";
            this.dateOfEmploymentDataGridViewTextBoxColumn.HeaderText = "DateOfEmployment";
            this.dateOfEmploymentDataGridViewTextBoxColumn.Name = "dateOfEmploymentDataGridViewTextBoxColumn";
            this.dateOfEmploymentDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfEmploymentDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateChangePositionDataGridViewTextBoxColumn
            // 
            this.dateChangePositionDataGridViewTextBoxColumn.DataPropertyName = "DateChangePosition";
            this.dateChangePositionDataGridViewTextBoxColumn.HeaderText = "DateChangePosition";
            this.dateChangePositionDataGridViewTextBoxColumn.Name = "dateChangePositionDataGridViewTextBoxColumn";
            this.dateChangePositionDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateChangePositionDataGridViewTextBoxColumn.Visible = false;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexDataGridViewTextBoxColumn.Visible = false;
            // 
            // growthDataGridViewTextBoxColumn
            // 
            this.growthDataGridViewTextBoxColumn.DataPropertyName = "Growth";
            this.growthDataGridViewTextBoxColumn.HeaderText = "Growth";
            this.growthDataGridViewTextBoxColumn.Name = "growthDataGridViewTextBoxColumn";
            this.growthDataGridViewTextBoxColumn.ReadOnly = true;
            this.growthDataGridViewTextBoxColumn.Visible = false;
            // 
            // clothingSizeDataGridViewTextBoxColumn
            // 
            this.clothingSizeDataGridViewTextBoxColumn.DataPropertyName = "ClothingSize";
            this.clothingSizeDataGridViewTextBoxColumn.HeaderText = "ClothingSize";
            this.clothingSizeDataGridViewTextBoxColumn.Name = "clothingSizeDataGridViewTextBoxColumn";
            this.clothingSizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.clothingSizeDataGridViewTextBoxColumn.Visible = false;
            // 
            // shoeSizeDataGridViewTextBoxColumn
            // 
            this.shoeSizeDataGridViewTextBoxColumn.DataPropertyName = "ShoeSize";
            this.shoeSizeDataGridViewTextBoxColumn.HeaderText = "ShoeSize";
            this.shoeSizeDataGridViewTextBoxColumn.Name = "shoeSizeDataGridViewTextBoxColumn";
            this.shoeSizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.shoeSizeDataGridViewTextBoxColumn.Visible = false;
            // 
            // headgearSizeDataGridViewTextBoxColumn
            // 
            this.headgearSizeDataGridViewTextBoxColumn.DataPropertyName = "HeadgearSize";
            this.headgearSizeDataGridViewTextBoxColumn.HeaderText = "HeadgearSize";
            this.headgearSizeDataGridViewTextBoxColumn.Name = "headgearSizeDataGridViewTextBoxColumn";
            this.headgearSizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.headgearSizeDataGridViewTextBoxColumn.Visible = false;
            // 
            // gasmaskSizeDataGridViewTextBoxColumn
            // 
            this.gasmaskSizeDataGridViewTextBoxColumn.DataPropertyName = "GasmaskSize";
            this.gasmaskSizeDataGridViewTextBoxColumn.HeaderText = "GasmaskSize";
            this.gasmaskSizeDataGridViewTextBoxColumn.Name = "gasmaskSizeDataGridViewTextBoxColumn";
            this.gasmaskSizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.gasmaskSizeDataGridViewTextBoxColumn.Visible = false;
            // 
            // respiratorSizeDataGridViewTextBoxColumn
            // 
            this.respiratorSizeDataGridViewTextBoxColumn.DataPropertyName = "RespiratorSize";
            this.respiratorSizeDataGridViewTextBoxColumn.HeaderText = "RespiratorSize";
            this.respiratorSizeDataGridViewTextBoxColumn.Name = "respiratorSizeDataGridViewTextBoxColumn";
            this.respiratorSizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.respiratorSizeDataGridViewTextBoxColumn.Visible = false;
            // 
            // gauntletsSizeDataGridViewTextBoxColumn
            // 
            this.gauntletsSizeDataGridViewTextBoxColumn.DataPropertyName = "GauntletsSize";
            this.gauntletsSizeDataGridViewTextBoxColumn.HeaderText = "GauntletsSize";
            this.gauntletsSizeDataGridViewTextBoxColumn.Name = "gauntletsSizeDataGridViewTextBoxColumn";
            this.gauntletsSizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.gauntletsSizeDataGridViewTextBoxColumn.Visible = false;
            // 
            // glovesSizeDataGridViewTextBoxColumn
            // 
            this.glovesSizeDataGridViewTextBoxColumn.DataPropertyName = "GlovesSize";
            this.glovesSizeDataGridViewTextBoxColumn.HeaderText = "GlovesSize";
            this.glovesSizeDataGridViewTextBoxColumn.Name = "glovesSizeDataGridViewTextBoxColumn";
            this.glovesSizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.glovesSizeDataGridViewTextBoxColumn.Visible = false;
            // 
            // iEmployeeBindingSource
            // 
            this.iEmployeeBindingSource.DataSource = typeof(Model.Employee.IEmployee);
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchGroupBox.Controls.Add(this.searchComboBox);
            this.searchGroupBox.Location = new System.Drawing.Point(345, 3);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(200, 49);
            this.searchGroupBox.TabIndex = 1;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Поиск по фамилии";
            this.searchGroupBox.Visible = false;
            // 
            // searchComboBox
            // 
            this.searchComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.searchComboBox.DataSource = this.iEmployeeBindingSource;
            this.searchComboBox.DisplayMember = "Surname";
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Location = new System.Drawing.Point(6, 19);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(188, 21);
            this.searchComboBox.TabIndex = 0;
            this.toolTip.SetToolTip(this.searchComboBox, "Начните вводить фамилию");
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // EmployesListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmployesListControl";
            this.Size = new System.Drawing.Size(548, 433);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEmployeeBindingSource)).EndInit();
            this.searchGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView employesGridView;
        private System.Windows.Forms.BindingSource iEmployeeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn structuralUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfEmploymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateChangePositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn growthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clothingSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoeSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headgearSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gasmaskSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn respiratorSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gauntletsSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn glovesSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
