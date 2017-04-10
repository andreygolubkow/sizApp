using System;
using System.Windows.Forms;

namespace SizView
{
    using Model.Employee;

    public partial class EmployeeForm : Form
    {
        public EmployeeForm(int id)
        {
            InitializeComponent();
            standartEmployeeControl.Id = id;
            DialogResult = DialogResult.Cancel;
        }

        public EmployeeForm(IEmployee employee)
        {
            InitializeComponent();
            standartEmployeeControl.Employee = (StandartEmployee)employee;
            standartEmployeeControl.Id = employee.Id;
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
