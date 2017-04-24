namespace SizView
{
    partial class IssueRecordAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueRecordAddForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fullNameEmployeeAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selectedProfessionsListBox = new System.Windows.Forms.ListBox();
            this.selectediProfessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.professionComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.professionEquipmentsGridView = new System.Windows.Forms.DataGridView();
            this.iProfessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iEquipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullNameEmployeeAdapterBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectediProfessionBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professionEquipmentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iProfessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEquipmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(591, 418);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(583, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Общая информация";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(583, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Профессии";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(583, 392);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Проверка";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataSource = this.fullNameEmployeeAdapterBindingSource;
            this.comboBox1.DisplayMember = "FullName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(559, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Employee";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(6, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 50);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Работник";
            // 
            // fullNameEmployeeAdapterBindingSource
            // 
            this.fullNameEmployeeAdapterBindingSource.DataSource = typeof(Tools.FullNameEmployeeAdapter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selectedProfessionsListBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 192);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавленные профессии";
            // 
            // selectedProfessionsListBox
            // 
            this.selectedProfessionsListBox.DataSource = this.selectediProfessionBindingSource;
            this.selectedProfessionsListBox.DisplayMember = "Name";
            this.selectedProfessionsListBox.FormattingEnabled = true;
            this.selectedProfessionsListBox.Location = new System.Drawing.Point(6, 19);
            this.selectedProfessionsListBox.Name = "selectedProfessionsListBox";
            this.selectedProfessionsListBox.Size = new System.Drawing.Size(287, 160);
            this.selectedProfessionsListBox.TabIndex = 0;
            // 
            // selectediProfessionBindingSource
            // 
            this.selectediProfessionBindingSource.DataSource = typeof(Model.Professions.IProfession);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.removeButton);
            this.groupBox3.Controls.Add(this.addButton);
            this.groupBox3.Location = new System.Drawing.Point(317, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 80);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Редактирование";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 19);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(248, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(6, 48);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(248, 23);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.professionEquipmentsGridView);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.professionComboBox);
            this.groupBox4.Location = new System.Drawing.Point(6, 204);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(571, 185);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Список СИЗ про профессиям";
            // 
            // professionComboBox
            // 
            this.professionComboBox.DataSource = this.iProfessionBindingSource;
            this.professionComboBox.DisplayMember = "Name";
            this.professionComboBox.FormattingEnabled = true;
            this.professionComboBox.Location = new System.Drawing.Point(77, 19);
            this.professionComboBox.Name = "professionComboBox";
            this.professionComboBox.Size = new System.Drawing.Size(488, 21);
            this.professionComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Профессия";
            // 
            // professionEquipmentsGridView
            // 
            this.professionEquipmentsGridView.AllowUserToAddRows = false;
            this.professionEquipmentsGridView.AllowUserToDeleteRows = false;
            this.professionEquipmentsGridView.AutoGenerateColumns = false;
            this.professionEquipmentsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.professionEquipmentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.professionEquipmentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.CountString});
            this.professionEquipmentsGridView.DataSource = this.iEquipmentBindingSource;
            this.professionEquipmentsGridView.Location = new System.Drawing.Point(6, 46);
            this.professionEquipmentsGridView.MultiSelect = false;
            this.professionEquipmentsGridView.Name = "professionEquipmentsGridView";
            this.professionEquipmentsGridView.ReadOnly = true;
            this.professionEquipmentsGridView.RowHeadersVisible = false;
            this.professionEquipmentsGridView.Size = new System.Drawing.Size(559, 133);
            this.professionEquipmentsGridView.TabIndex = 2;
            // 
            // iProfessionBindingSource
            // 
            this.iProfessionBindingSource.DataSource = typeof(Model.Professions.IProfession);
            // 
            // iEquipmentBindingSource
            // 
            this.iEquipmentBindingSource.DataSource = typeof(Model.Equipments.IEquipment);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CountString
            // 
            this.CountString.DataPropertyName = "CountString";
            this.CountString.HeaderText = "Количество";
            this.CountString.Name = "CountString";
            this.CountString.ReadOnly = true;
            // 
            // IssueRecordAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 442);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IssueRecordAddForm";
            this.Text = "Выдача СИЗ";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fullNameEmployeeAdapterBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectediProfessionBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professionEquipmentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iProfessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEquipmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.BindingSource fullNameEmployeeAdapterBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox selectedProfessionsListBox;
        private System.Windows.Forms.BindingSource selectediProfessionBindingSource;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView professionEquipmentsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountString;
        private System.Windows.Forms.BindingSource iEquipmentBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox professionComboBox;
        private System.Windows.Forms.BindingSource iProfessionBindingSource;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
    }
}