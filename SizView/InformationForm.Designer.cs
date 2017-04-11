namespace SizView
{
    partial class InformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.otherTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.otherRadioButton = new System.Windows.Forms.RadioButton();
            this.leaderRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.leaderPositionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.leaderFullNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.organisationShortNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.organisationFullNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.zoneStringTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.additionalComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.zoneComboBox = new System.Windows.Forms.ComboBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.organisationShortNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.organisationFullNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Общая информация";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.otherTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.otherRadioButton);
            this.groupBox3.Controls.Add(this.leaderRadioButton);
            this.groupBox3.Location = new System.Drawing.Point(9, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 91);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ответственное лицо";
            // 
            // otherTextBox
            // 
            this.otherTextBox.Enabled = false;
            this.otherTextBox.Location = new System.Drawing.Point(46, 59);
            this.otherTextBox.Name = "otherTextBox";
            this.otherTextBox.Size = new System.Drawing.Size(300, 20);
            this.otherTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "ФИО";
            // 
            // otherRadioButton
            // 
            this.otherRadioButton.AutoSize = true;
            this.otherRadioButton.Location = new System.Drawing.Point(9, 42);
            this.otherRadioButton.Name = "otherRadioButton";
            this.otherRadioButton.Size = new System.Drawing.Size(112, 17);
            this.otherRadioButton.TabIndex = 6;
            this.otherRadioButton.Text = "Другой работник";
            this.otherRadioButton.UseVisualStyleBackColor = true;
            // 
            // leaderRadioButton
            // 
            this.leaderRadioButton.AutoSize = true;
            this.leaderRadioButton.Checked = true;
            this.leaderRadioButton.Location = new System.Drawing.Point(9, 19);
            this.leaderRadioButton.Name = "leaderRadioButton";
            this.leaderRadioButton.Size = new System.Drawing.Size(164, 17);
            this.leaderRadioButton.TabIndex = 5;
            this.leaderRadioButton.TabStop = true;
            this.leaderRadioButton.Text = "Руководитель организации";
            this.leaderRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.leaderPositionTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.leaderFullNameTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(9, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Руководитель";
            // 
            // leaderPositionTextBox
            // 
            this.leaderPositionTextBox.Location = new System.Drawing.Point(35, 71);
            this.leaderPositionTextBox.Name = "leaderPositionTextBox";
            this.leaderPositionTextBox.Size = new System.Drawing.Size(311, 20);
            this.leaderPositionTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Должность руководителя";
            // 
            // leaderFullNameTextBox
            // 
            this.leaderFullNameTextBox.Location = new System.Drawing.Point(35, 32);
            this.leaderFullNameTextBox.Name = "leaderFullNameTextBox";
            this.leaderFullNameTextBox.Size = new System.Drawing.Size(311, 20);
            this.leaderFullNameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ФИО руководителя организации";
            // 
            // organisationShortNameTextBox
            // 
            this.organisationShortNameTextBox.Location = new System.Drawing.Point(44, 71);
            this.organisationShortNameTextBox.Name = "organisationShortNameTextBox";
            this.organisationShortNameTextBox.Size = new System.Drawing.Size(317, 20);
            this.organisationShortNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Краткое наименование организации";
            // 
            // organisationFullNameTextBox
            // 
            this.organisationFullNameTextBox.Location = new System.Drawing.Point(44, 32);
            this.organisationFullNameTextBox.Name = "organisationFullNameTextBox";
            this.organisationFullNameTextBox.Size = new System.Drawing.Size(317, 20);
            this.organisationFullNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Полное наименование организации";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.zoneStringTextBox);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.additionalComboBox);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.zoneComboBox);
            this.groupBox4.Controls.Add(this.cityTextBox);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(385, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(328, 126);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Климатический пояс";
            // 
            // zoneStringTextBox
            // 
            this.zoneStringTextBox.Location = new System.Drawing.Point(127, 94);
            this.zoneStringTextBox.Name = "zoneStringTextBox";
            this.zoneStringTextBox.ReadOnly = true;
            this.zoneStringTextBox.Size = new System.Drawing.Size(100, 20);
            this.zoneStringTextBox.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Климатический пояс";
            // 
            // additionalComboBox
            // 
            this.additionalComboBox.Enabled = false;
            this.additionalComboBox.FormattingEnabled = true;
            this.additionalComboBox.Location = new System.Drawing.Point(90, 68);
            this.additionalComboBox.Name = "additionalComboBox";
            this.additionalComboBox.Size = new System.Drawing.Size(232, 21);
            this.additionalComboBox.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Уточнение";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Область, край";
            // 
            // zoneComboBox
            // 
            this.zoneComboBox.FormattingEnabled = true;
            this.zoneComboBox.Location = new System.Drawing.Point(90, 39);
            this.zoneComboBox.Name = "zoneComboBox";
            this.zoneComboBox.Size = new System.Drawing.Size(232, 21);
            this.zoneComboBox.TabIndex = 9;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(49, 13);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(273, 20);
            this.cityTextBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Город";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(466, 144);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(247, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(385, 144);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 326);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InformationForm";
            this.Text = "Информация";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox organisationFullNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox organisationShortNameTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox otherTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton otherRadioButton;
        private System.Windows.Forms.RadioButton leaderRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox leaderPositionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox leaderFullNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox zoneStringTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox additionalComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox zoneComboBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}