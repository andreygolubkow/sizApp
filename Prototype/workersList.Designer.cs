namespace Prototype
{
    partial class workersList
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.базаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьРаботникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сИЗToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giveSizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВБазуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workersListView = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartUse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalisGroupBox = new System.Windows.Forms.GroupBox();
            this.sizGridView = new System.Windows.Forms.DataGridView();
            this.nameSiz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startExplatuation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expitiesSiz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersListView)).BeginInit();
            this.detalisGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.базаДанныхToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(566, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // базаДанныхToolStripMenuItem
            // 
            this.базаДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьРаботникаToolStripMenuItem,
            this.сИЗToolStripMenuItem});
            this.базаДанныхToolStripMenuItem.Name = "базаДанныхToolStripMenuItem";
            this.базаДанныхToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.базаДанныхToolStripMenuItem.Text = "Действия";
            // 
            // добавитьРаботникаToolStripMenuItem
            // 
            this.добавитьРаботникаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem});
            this.добавитьРаботникаToolStripMenuItem.Name = "добавитьРаботникаToolStripMenuItem";
            this.добавитьРаботникаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.добавитьРаботникаToolStripMenuItem.Text = "Работники";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // сИЗToolStripMenuItem
            // 
            this.сИЗToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giveSizToolStripMenuItem,
            this.добавитьВБазуToolStripMenuItem});
            this.сИЗToolStripMenuItem.Name = "сИЗToolStripMenuItem";
            this.сИЗToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сИЗToolStripMenuItem.Text = "СИЗ";
            // 
            // giveSizToolStripMenuItem
            // 
            this.giveSizToolStripMenuItem.Name = "giveSizToolStripMenuItem";
            this.giveSizToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.giveSizToolStripMenuItem.Text = "Выдать комплект";
            this.giveSizToolStripMenuItem.Click += new System.EventHandler(this.giveSizToolStripMenuItem_Click);
            // 
            // добавитьВБазуToolStripMenuItem
            // 
            this.добавитьВБазуToolStripMenuItem.Name = "добавитьВБазуToolStripMenuItem";
            this.добавитьВБазуToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.добавитьВБазуToolStripMenuItem.Text = "Добавить в базу";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // workersListView
            // 
            this.workersListView.AllowUserToAddRows = false;
            this.workersListView.AllowUserToDeleteRows = false;
            this.workersListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workersListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.lname,
            this.profession,
            this.StartUse,
            this.expiries});
            this.workersListView.Location = new System.Drawing.Point(12, 27);
            this.workersListView.Name = "workersListView";
            this.workersListView.ReadOnly = true;
            this.workersListView.RowHeadersVisible = false;
            this.workersListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.workersListView.Size = new System.Drawing.Size(547, 274);
            this.workersListView.TabIndex = 1;
            this.workersListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.workersListView_CellContentClick);
            this.workersListView.Click += new System.EventHandler(this.workersListView_Click);
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Имя";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // lname
            // 
            this.lname.HeaderText = "Фамилия";
            this.lname.Name = "lname";
            this.lname.ReadOnly = true;
            // 
            // profession
            // 
            this.profession.HeaderText = "Профессия";
            this.profession.Name = "profession";
            this.profession.ReadOnly = true;
            // 
            // StartUse
            // 
            this.StartUse.HeaderText = "Начало эксплуатации";
            this.StartUse.Name = "StartUse";
            this.StartUse.ReadOnly = true;
            // 
            // expiries
            // 
            this.expiries.HeaderText = "Истекает";
            this.expiries.Name = "expiries";
            this.expiries.ReadOnly = true;
            // 
            // detalisGroupBox
            // 
            this.detalisGroupBox.Controls.Add(this.sizGridView);
            this.detalisGroupBox.Controls.Add(this.label6);
            this.detalisGroupBox.Controls.Add(this.label5);
            this.detalisGroupBox.Controls.Add(this.label4);
            this.detalisGroupBox.Controls.Add(this.label3);
            this.detalisGroupBox.Controls.Add(this.label2);
            this.detalisGroupBox.Controls.Add(this.nameLabel);
            this.detalisGroupBox.Controls.Add(this.label1);
            this.detalisGroupBox.Location = new System.Drawing.Point(12, 307);
            this.detalisGroupBox.Name = "detalisGroupBox";
            this.detalisGroupBox.Size = new System.Drawing.Size(547, 183);
            this.detalisGroupBox.TabIndex = 2;
            this.detalisGroupBox.TabStop = false;
            this.detalisGroupBox.Text = "Детали";
            this.detalisGroupBox.Visible = false;
            // 
            // sizGridView
            // 
            this.sizGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sizGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameSiz,
            this.startExplatuation,
            this.expitiesSiz});
            this.sizGridView.Location = new System.Drawing.Point(160, 32);
            this.sizGridView.Name = "sizGridView";
            this.sizGridView.RowHeadersVisible = false;
            this.sizGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sizGridView.Size = new System.Drawing.Size(381, 140);
            this.sizGridView.TabIndex = 7;
            // 
            // nameSiz
            // 
            this.nameSiz.HeaderText = "Наименование";
            this.nameSiz.Name = "nameSiz";
            // 
            // startExplatuation
            // 
            this.startExplatuation.HeaderText = "Начало эксплуатации";
            this.startExplatuation.Name = "startExplatuation";
            // 
            // expitiesSiz
            // 
            this.expitiesSiz.HeaderText = "Годен до";
            this.expitiesSiz.Name = "expitiesSiz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Сведения о комплекте СИЗ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Строитель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Профессия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Голубков";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(91, 16);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Андрей";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя работника";
            // 
            // workersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 496);
            this.Controls.Add(this.detalisGroupBox);
            this.Controls.Add(this.workersListView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "workersList";
            this.Text = "Список работников";
            this.Load += new System.EventHandler(this.workersList_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersListView)).EndInit();
            this.detalisGroupBox.ResumeLayout(false);
            this.detalisGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem базаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.DataGridView workersListView;
        private System.Windows.Forms.GroupBox detalisGroupBox;
        private System.Windows.Forms.DataGridView sizGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSiz;
        private System.Windows.Forms.DataGridViewTextBoxColumn startExplatuation;
        private System.Windows.Forms.DataGridViewTextBoxColumn expitiesSiz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn profession;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiries;
        private System.Windows.Forms.ToolStripMenuItem добавитьРаботникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сИЗToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giveSizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьВБазуToolStripMenuItem;
    }
}

