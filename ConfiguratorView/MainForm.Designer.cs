namespace ConfiguratorView
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.zoneActionsGroupBox = new System.Windows.Forms.GroupBox();
            this.applyZoneButton = new System.Windows.Forms.Button();
            this.removeZoneButton = new System.Windows.Forms.Button();
            this.addZoneButton = new System.Windows.Forms.Button();
            this.zoneGroupBox = new System.Windows.Forms.GroupBox();
            this.zoneAsStringTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zoneNumTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zonesGridView = new System.Windows.Forms.DataGridView();
            this.iZoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.removeRegionButton = new System.Windows.Forms.Button();
            this.addRegionButton = new System.Windows.Forms.Button();
            this.applyRegionButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.additionalRegionCheckBox = new System.Windows.Forms.CheckBox();
            this.regionZoneComboBox = new System.Windows.Forms.ComboBox();
            this.regionAdditionTextBox = new System.Windows.Forms.TextBox();
            this.regionNameTextBox = new System.Windows.Forms.TextBox();
            this.regionsGridView = new System.Windows.Forms.DataGridView();
            this.iRegionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.zoneActionsGroupBox.SuspendLayout();
            this.zoneGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zonesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iZoneBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regionsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iRegionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(531, 368);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.zoneActionsGroupBox);
            this.tabPage1.Controls.Add(this.zoneGroupBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.zonesGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(523, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пояса";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // zoneActionsGroupBox
            // 
            this.zoneActionsGroupBox.Controls.Add(this.applyZoneButton);
            this.zoneActionsGroupBox.Controls.Add(this.removeZoneButton);
            this.zoneActionsGroupBox.Controls.Add(this.addZoneButton);
            this.zoneActionsGroupBox.Location = new System.Drawing.Point(233, 253);
            this.zoneActionsGroupBox.Name = "zoneActionsGroupBox";
            this.zoneActionsGroupBox.Size = new System.Drawing.Size(284, 83);
            this.zoneActionsGroupBox.TabIndex = 3;
            this.zoneActionsGroupBox.TabStop = false;
            this.zoneActionsGroupBox.Text = "Действия";
            // 
            // applyZoneButton
            // 
            this.applyZoneButton.Location = new System.Drawing.Point(6, 48);
            this.applyZoneButton.Name = "applyZoneButton";
            this.applyZoneButton.Size = new System.Drawing.Size(272, 23);
            this.applyZoneButton.TabIndex = 2;
            this.applyZoneButton.Text = "Применить правку ";
            this.applyZoneButton.UseVisualStyleBackColor = true;
            this.applyZoneButton.Click += new System.EventHandler(this.ApplyZoneButtonClick);
            // 
            // removeZoneButton
            // 
            this.removeZoneButton.Location = new System.Drawing.Point(130, 19);
            this.removeZoneButton.Name = "removeZoneButton";
            this.removeZoneButton.Size = new System.Drawing.Size(148, 23);
            this.removeZoneButton.TabIndex = 1;
            this.removeZoneButton.Text = "Удалить";
            this.removeZoneButton.UseVisualStyleBackColor = true;
            this.removeZoneButton.Click += new System.EventHandler(this.RemoveZoneButtonClick);
            // 
            // addZoneButton
            // 
            this.addZoneButton.Location = new System.Drawing.Point(6, 19);
            this.addZoneButton.Name = "addZoneButton";
            this.addZoneButton.Size = new System.Drawing.Size(118, 23);
            this.addZoneButton.TabIndex = 0;
            this.addZoneButton.Text = "Добавить пояс";
            this.addZoneButton.UseVisualStyleBackColor = true;
            this.addZoneButton.Click += new System.EventHandler(this.AddZoneButtonClick);
            // 
            // zoneGroupBox
            // 
            this.zoneGroupBox.Controls.Add(this.zoneAsStringTextBox);
            this.zoneGroupBox.Controls.Add(this.label3);
            this.zoneGroupBox.Controls.Add(this.label2);
            this.zoneGroupBox.Controls.Add(this.zoneNumTextBox);
            this.zoneGroupBox.Location = new System.Drawing.Point(233, 19);
            this.zoneGroupBox.Name = "zoneGroupBox";
            this.zoneGroupBox.Size = new System.Drawing.Size(284, 103);
            this.zoneGroupBox.TabIndex = 2;
            this.zoneGroupBox.TabStop = false;
            this.zoneGroupBox.Text = "Информация";
            // 
            // zoneAsStringTextBox
            // 
            this.zoneAsStringTextBox.Location = new System.Drawing.Point(6, 75);
            this.zoneAsStringTextBox.Name = "zoneAsStringTextBox";
            this.zoneAsStringTextBox.Size = new System.Drawing.Size(272, 20);
            this.zoneAsStringTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Строковое представление";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер пояса";
            // 
            // zoneNumTextBox
            // 
            this.zoneNumTextBox.Location = new System.Drawing.Point(6, 32);
            this.zoneNumTextBox.Name = "zoneNumTextBox";
            this.zoneNumTextBox.Size = new System.Drawing.Size(134, 20);
            this.zoneNumTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список поясов";
            // 
            // zonesGridView
            // 
            this.zonesGridView.AllowUserToAddRows = false;
            this.zonesGridView.AllowUserToDeleteRows = false;
            this.zonesGridView.AutoGenerateColumns = false;
            this.zonesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zonesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numDataGridViewTextBoxColumn,
            this.asStringDataGridViewTextBoxColumn});
            this.zonesGridView.DataSource = this.iZoneBindingSource;
            this.zonesGridView.Location = new System.Drawing.Point(6, 19);
            this.zonesGridView.Name = "zonesGridView";
            this.zonesGridView.ReadOnly = true;
            this.zonesGridView.RowHeadersVisible = false;
            this.zonesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.zonesGridView.Size = new System.Drawing.Size(221, 317);
            this.zonesGridView.TabIndex = 0;
            this.zonesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ZonesGridViewCellClick);
            // 
            // iZoneBindingSource
            // 
            this.iZoneBindingSource.DataSource = typeof(Model.Zones.IZone);
            this.iZoneBindingSource.CurrentChanged += new System.EventHandler(this.iZoneBindingSource_CurrentChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.regionsGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(523, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Регионы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.removeRegionButton);
            this.groupBox2.Controls.Add(this.addRegionButton);
            this.groupBox2.Controls.Add(this.applyRegionButton);
            this.groupBox2.Location = new System.Drawing.Point(247, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 77);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Действия";
            // 
            // removeRegionButton
            // 
            this.removeRegionButton.Location = new System.Drawing.Point(156, 19);
            this.removeRegionButton.Name = "removeRegionButton";
            this.removeRegionButton.Size = new System.Drawing.Size(108, 23);
            this.removeRegionButton.TabIndex = 2;
            this.removeRegionButton.Text = "Удалить регион";
            this.removeRegionButton.UseVisualStyleBackColor = true;
            this.removeRegionButton.Click += new System.EventHandler(this.RemoveRegionButtonClick);
            // 
            // addRegionButton
            // 
            this.addRegionButton.Location = new System.Drawing.Point(9, 19);
            this.addRegionButton.Name = "addRegionButton";
            this.addRegionButton.Size = new System.Drawing.Size(141, 23);
            this.addRegionButton.TabIndex = 1;
            this.addRegionButton.Text = "Добавить регион";
            this.addRegionButton.UseVisualStyleBackColor = true;
            this.addRegionButton.Click += new System.EventHandler(this.AddRegionButtonClick);
            // 
            // applyRegionButton
            // 
            this.applyRegionButton.Location = new System.Drawing.Point(9, 48);
            this.applyRegionButton.Name = "applyRegionButton";
            this.applyRegionButton.Size = new System.Drawing.Size(258, 23);
            this.applyRegionButton.TabIndex = 0;
            this.applyRegionButton.Text = "Применить правку";
            this.applyRegionButton.UseVisualStyleBackColor = true;
            this.applyRegionButton.Click += new System.EventHandler(this.ApplyRegionButtonClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Список регионов по поясам";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.additionalRegionCheckBox);
            this.groupBox1.Controls.Add(this.regionZoneComboBox);
            this.groupBox1.Controls.Add(this.regionAdditionTextBox);
            this.groupBox1.Controls.Add(this.regionNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(247, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 145);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Пояс";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Уточнение";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Край, область, республика";
            // 
            // additionalRegionCheckBox
            // 
            this.additionalRegionCheckBox.AutoSize = true;
            this.additionalRegionCheckBox.Location = new System.Drawing.Point(184, 71);
            this.additionalRegionCheckBox.Name = "additionalRegionCheckBox";
            this.additionalRegionCheckBox.Size = new System.Drawing.Size(80, 17);
            this.additionalRegionCheckBox.TabIndex = 3;
            this.additionalRegionCheckBox.Text = "Уточнение";
            this.additionalRegionCheckBox.UseVisualStyleBackColor = true;
            this.additionalRegionCheckBox.CheckedChanged += new System.EventHandler(this.AdditionalRegionCheckBoxCheckedChanged);
            // 
            // regionZoneComboBox
            // 
            this.regionZoneComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.regionZoneComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.regionZoneComboBox.DataSource = this.iZoneBindingSource;
            this.regionZoneComboBox.DisplayMember = "AsString";
            this.regionZoneComboBox.FormattingEnabled = true;
            this.regionZoneComboBox.Location = new System.Drawing.Point(9, 110);
            this.regionZoneComboBox.Name = "regionZoneComboBox";
            this.regionZoneComboBox.Size = new System.Drawing.Size(255, 21);
            this.regionZoneComboBox.TabIndex = 2;
            this.regionZoneComboBox.ValueMember = "Id";
            // 
            // regionAdditionTextBox
            // 
            this.regionAdditionTextBox.Enabled = false;
            this.regionAdditionTextBox.Location = new System.Drawing.Point(9, 71);
            this.regionAdditionTextBox.Name = "regionAdditionTextBox";
            this.regionAdditionTextBox.Size = new System.Drawing.Size(169, 20);
            this.regionAdditionTextBox.TabIndex = 1;
            // 
            // regionNameTextBox
            // 
            this.regionNameTextBox.Location = new System.Drawing.Point(9, 32);
            this.regionNameTextBox.Name = "regionNameTextBox";
            this.regionNameTextBox.Size = new System.Drawing.Size(255, 20);
            this.regionNameTextBox.TabIndex = 0;
            // 
            // regionsGridView
            // 
            this.regionsGridView.AllowUserToAddRows = false;
            this.regionsGridView.AllowUserToDeleteRows = false;
            this.regionsGridView.AutoGenerateColumns = false;
            this.regionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.regionsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.zoneDataGridViewTextBoxColumn});
            this.regionsGridView.DataSource = this.iRegionBindingSource;
            this.regionsGridView.Location = new System.Drawing.Point(6, 27);
            this.regionsGridView.Name = "regionsGridView";
            this.regionsGridView.ReadOnly = true;
            this.regionsGridView.RowHeadersVisible = false;
            this.regionsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.regionsGridView.Size = new System.Drawing.Size(235, 309);
            this.regionsGridView.TabIndex = 0;
            this.regionsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RegionsGridViewCellClick);
            // 
            // iRegionBindingSource
            // 
            this.iRegionBindingSource.DataSource = typeof(Model.Regions.IRegion);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            this.idDataGridViewTextBoxColumn1.Width = 5;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zoneDataGridViewTextBoxColumn
            // 
            this.zoneDataGridViewTextBoxColumn.DataPropertyName = "Zone";
            this.zoneDataGridViewTextBoxColumn.HeaderText = "Пояс";
            this.zoneDataGridViewTextBoxColumn.Name = "zoneDataGridViewTextBoxColumn";
            this.zoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.zoneDataGridViewTextBoxColumn.Visible = false;
            this.zoneDataGridViewTextBoxColumn.Width = 130;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Идентификатор";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 5;
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            this.numDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            this.numDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asStringDataGridViewTextBoxColumn
            // 
            this.asStringDataGridViewTextBoxColumn.DataPropertyName = "AsString";
            this.asStringDataGridViewTextBoxColumn.HeaderText = "Строковое представление";
            this.asStringDataGridViewTextBoxColumn.Name = "asStringDataGridViewTextBoxColumn";
            this.asStringDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 392);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Конфигурация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.zoneActionsGroupBox.ResumeLayout(false);
            this.zoneGroupBox.ResumeLayout(false);
            this.zoneGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zonesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iZoneBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regionsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iRegionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView zonesGridView;
        private System.Windows.Forms.BindingSource iZoneBindingSource;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox zoneActionsGroupBox;
        private System.Windows.Forms.Button applyZoneButton;
        private System.Windows.Forms.Button removeZoneButton;
        private System.Windows.Forms.Button addZoneButton;
        private System.Windows.Forms.GroupBox zoneGroupBox;
        private System.Windows.Forms.TextBox zoneAsStringTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox zoneNumTextBox;
        private System.Windows.Forms.DataGridView regionsGridView;
        private System.Windows.Forms.BindingSource iRegionBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox additionalRegionCheckBox;
        private System.Windows.Forms.ComboBox regionZoneComboBox;
        private System.Windows.Forms.TextBox regionAdditionTextBox;
        private System.Windows.Forms.TextBox regionNameTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button removeRegionButton;
        private System.Windows.Forms.Button addRegionButton;
        private System.Windows.Forms.Button applyRegionButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoneDataGridViewTextBoxColumn;
    }
}

