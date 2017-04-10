using System;
using System.Windows.Forms;

namespace SizView
{
    using System.Collections.Generic;

    using Model.Employee;
    using Model.Professions;

    public partial class EmployeeForm : Form
    {
        public EmployeeForm(int id,List<IProfession> professions )
        {
            InitializeComponent();
            standartEmployeeControl.Id = id;
            standartEmployeeControl.Professions = professions;
            DialogResult = DialogResult.Cancel;
            addButton.Text = "Добавить";
        }

        public EmployeeForm(IEmployee employee, List<IProfession> professions)
        {
            InitializeComponent();
            standartEmployeeControl.Professions = professions;
            standartEmployeeControl.Employee = (StandartEmployee)employee;
            standartEmployeeControl.Id = employee.Id;
            addButton.Text = "Сохранить";
            DialogResult = DialogResult.Cancel;
        }


        public IEmployee Employee => standartEmployeeControl.Employee;

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                var a = standartEmployeeControl.Employee;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void EmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
