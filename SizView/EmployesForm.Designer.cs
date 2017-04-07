namespace SizView
{
    partial class EmployesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployesForm));
            this.employeeMenuStrip = new System.Windows.Forms.MenuStrip();
            this.employesListControl = new SizView.Controls.EmployesListControl();
            this.SuspendLayout();
            // 
            // employeeMenuStrip
            // 
            this.employeeMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.employeeMenuStrip.Name = "employeeMenuStrip";
            this.employeeMenuStrip.Size = new System.Drawing.Size(747, 24);
            this.employeeMenuStrip.TabIndex = 1;
            this.employeeMenuStrip.Text = "menuStrip1";
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
            // EmployesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 483);
            this.Controls.Add(this.employesListControl);
            this.Controls.Add(this.employeeMenuStrip);
            this.MainMenuStrip = this.employeeMenuStrip;
            this.Name = "EmployesForm";
            this.Text = "Работники";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.EmployesListControl employesListControl;
        private System.Windows.Forms.MenuStrip employeeMenuStrip;
    }
}