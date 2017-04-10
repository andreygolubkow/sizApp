namespace SizView
{
    using System;
    using System.Collections.Generic;

    using Model.Professions;

    using SizView.Properties;

    partial class EmployeeForm
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
            this.standartEmployeeControl = new SizView.Controls.StandartEmployeeControl();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // standartEmployeeControl
            // 
            this.standartEmployeeControl.Id = 0;
            this.standartEmployeeControl.Location = new System.Drawing.Point(12, 12);
            this.standartEmployeeControl.Name = "standartEmployeeControl";
            this.standartEmployeeControl.Size = new System.Drawing.Size(304, 470);
            this.standartEmployeeControl.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(93, 488);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(223, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 488);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // EmployeeForm
            // 
            this.ClientSize = new System.Drawing.Size(330, 526);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.standartEmployeeControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeForm";
            this.ShowIcon = false;
            this.Text = "Добавить работника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.StandartEmployeeControl standartEmployeeControl;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
    }
}