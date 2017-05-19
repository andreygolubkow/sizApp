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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newIssueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createBlankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProvisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizListControl = new SizView.Controls.SizListControl();
            this.saveDocumentDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.viewMenuItem,
            this.controlMenuItem,
            this.documentsMenuItem});
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
            this.fileMenuItem.Click += new System.EventHandler(this.fileMenuItem_Click);
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
            this.showInfoMenuItem.Click += new System.EventHandler(this.showInfoMenuItem_Click);
            // 
            // controlMenuItem
            // 
            this.controlMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employesMenuItem,
            this.informationMenuItem,
            this.sizToolStripMenuItem});
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
            this.informationMenuItem.Click += new System.EventHandler(this.InformationMenuItemClick);
            // 
            // sizToolStripMenuItem
            // 
            this.sizToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newIssueMenuItem,
            this.actualMenuItem});
            this.sizToolStripMenuItem.Name = "sizToolStripMenuItem";
            this.sizToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.sizToolStripMenuItem.Text = "СИЗ";
            // 
            // newIssueMenuItem
            // 
            this.newIssueMenuItem.Name = "newIssueMenuItem";
            this.newIssueMenuItem.Size = new System.Drawing.Size(149, 22);
            this.newIssueMenuItem.Text = "Выдать";
            this.newIssueMenuItem.Click += new System.EventHandler(this.newIssueMenuItem_Click);
            // 
            // actualMenuItem
            // 
            this.actualMenuItem.CheckOnClick = true;
            this.actualMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.actualMenuItem.Name = "actualMenuItem";
            this.actualMenuItem.Size = new System.Drawing.Size(149, 22);
            this.actualMenuItem.Text = "Актуальность";
            this.actualMenuItem.Click += new System.EventHandler(this.actualMenuItem_Click);
            // 
            // documentsMenuItem
            // 
            this.documentsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createBlankToolStripMenuItem,
            this.createProvisionToolStripMenuItem,
            this.createOrderToolStripMenuItem});
            this.documentsMenuItem.Name = "documentsMenuItem";
            this.documentsMenuItem.Size = new System.Drawing.Size(82, 20);
            this.documentsMenuItem.Text = "Документы";
            // 
            // createBlankToolStripMenuItem
            // 
            this.createBlankToolStripMenuItem.Name = "createBlankToolStripMenuItem";
            this.createBlankToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.createBlankToolStripMenuItem.Text = "Сформировать бланк";
            this.createBlankToolStripMenuItem.Click += new System.EventHandler(this.CreateBlankToolStripMenuItemClick);
            // 
            // createProvisionToolStripMenuItem
            // 
            this.createProvisionToolStripMenuItem.Name = "createProvisionToolStripMenuItem";
            this.createProvisionToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.createProvisionToolStripMenuItem.Text = "Сформировать положение";
            this.createProvisionToolStripMenuItem.Click += new System.EventHandler(this.createProvisionToolStripMenuItem_Click);
            // 
            // createOrderToolStripMenuItem
            // 
            this.createOrderToolStripMenuItem.Name = "createOrderToolStripMenuItem";
            this.createOrderToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.createOrderToolStripMenuItem.Text = "Сформировать приказ";
            this.createOrderToolStripMenuItem.Click += new System.EventHandler(this.createOrderToolStripMenuItem_Click);
            // 
            // sizListControl
            // 
            this.sizListControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sizListControl.IssueRecords = ((System.Collections.Generic.List<Model.Project.IssueRecord>)(resources.GetObject("sizListControl.IssueRecords")));
            this.sizListControl.Location = new System.Drawing.Point(0, 27);
            this.sizListControl.Name = "sizListControl";
            this.sizListControl.Size = new System.Drawing.Size(680, 296);
            this.sizListControl.TabIndex = 1;
            this.sizListControl.CurrentChanged += new System.EventHandler(this.SizListControlCurrentChanged);
            // 
            // saveDocumentDialog
            // 
            this.saveDocumentDialog.DefaultExt = "docx";
            this.saveDocumentDialog.Filter = "Документ Word|*.docx";
            this.saveDocumentDialog.Title = "Сохранение документа";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 322);
            this.Controls.Add(this.sizListControl);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "СИЗ: нормы и контроль";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showInfoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationMenuItem;
        private Controls.SizListControl sizListControl;
        private System.Windows.Forms.ToolStripMenuItem sizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newIssueMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createBlankToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveDocumentDialog;
        private System.Windows.Forms.ToolStripMenuItem createProvisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createOrderToolStripMenuItem;
    }
}

