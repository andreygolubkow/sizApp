namespace SizView
{
    partial class EmployesListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployesListForm));
            this.employeeMenuStrip = new System.Windows.Forms.MenuStrip();
            this.listMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.searchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employesListControl = new SizView.Controls.EmployesListControl();
            this.employeeMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeMenuStrip
            // 
            this.employeeMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listMenuItem});
            this.employeeMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.employeeMenuStrip.Name = "employeeMenuStrip";
            this.employeeMenuStrip.Size = new System.Drawing.Size(747, 24);
            this.employeeMenuStrip.TabIndex = 1;
            this.employeeMenuStrip.Text = "menuStrip1";
            // 
            // listMenuItem
            // 
            this.listMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMenuItem,
            this.editMenuItem,
            this.removeMenuItem,
            this.toolStripSeparator1,
            this.searchMenuItem});
            this.listMenuItem.Name = "listMenuItem";
            this.listMenuItem.Size = new System.Drawing.Size(60, 20);
            this.listMenuItem.Text = "Список";
            // 
            // addMenuItem
            // 
            this.addMenuItem.Name = "addMenuItem";
            this.addMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.addMenuItem.Size = new System.Drawing.Size(168, 22);
            this.addMenuItem.Text = "Добавить";
            this.addMenuItem.Click += new System.EventHandler(this.addMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editMenuItem.Size = new System.Drawing.Size(168, 22);
            this.editMenuItem.Text = "Изменить";
            this.editMenuItem.Click += new System.EventHandler(this.editMenuItem_Click);
            // 
            // removeMenuItem
            // 
            this.removeMenuItem.Name = "removeMenuItem";
            this.removeMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.removeMenuItem.Size = new System.Drawing.Size(168, 22);
            this.removeMenuItem.Text = "Удалить";
            this.removeMenuItem.Click += new System.EventHandler(this.removeMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // searchMenuItem
            // 
            this.searchMenuItem.Name = "searchMenuItem";
            this.searchMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.searchMenuItem.Size = new System.Drawing.Size(168, 22);
            this.searchMenuItem.Text = "Поиск";
            this.searchMenuItem.Click += new System.EventHandler(this.searchMenuItem_Click);
            // 
            // employesListControl
            // 
            this.employesListControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employesListControl.Employees = ((System.Collections.Generic.IList<Model.Employee.IEmployee>)(resources.GetObject("employesListControl.Employees")));
            this.employesListControl.Location = new System.Drawing.Point(0, 27);
            this.employesListControl.Name = "employesListControl";
            this.employesListControl.SearchBox = false;
            this.employesListControl.Size = new System.Drawing.Size(747, 456);
            this.employesListControl.TabIndex = 0;
            // 
            // EmployesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 483);
            this.Controls.Add(this.employesListControl);
            this.Controls.Add(this.employeeMenuStrip);
            this.MainMenuStrip = this.employeeMenuStrip;
            this.Name = "EmployesListForm";
            this.Text = "Работники";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployesListForm_FormClosing);
            this.Load += new System.EventHandler(this.EmployesForm_Load);
            this.employeeMenuStrip.ResumeLayout(false);
            this.employeeMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.EmployesListControl employesListControl;
        private System.Windows.Forms.MenuStrip employeeMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem listMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem searchMenuItem;
    }
}