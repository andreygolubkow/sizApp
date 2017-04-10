using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tools;

namespace SizView
{
    using System.Linq;

    using Model.Employee;

    public partial class EmployesListForm : Form
    {


        public EmployesListForm()
        {
            InitializeComponent();
            var empList = new List<IEmployee>();
            try
            {
                DataSerializer.DeserializeBin("employesList.sdb", ref empList);
            }
            catch (Exception)
            {
                empList = new List<IEmployee>();
            }
            employesListControl.Employees = empList;
        }

        private void EmployesForm_Load(object sender, EventArgs e)
        {

        }

        private void searchMenuItem_Click(object sender, EventArgs e)
        {
            employesListControl.SearchBox = !employesListControl.SearchBox;
        }

        private void addMenuItem_Click(object sender, EventArgs e)
        {
            int id = employesListControl.Employees.Select(item => item.Id).Concat(new[]
                                                                  {
                                                                      0
                                                                  }).Max();
            var addForm = new EmployeeForm(id+1);
            if ( addForm.ShowDialog() == DialogResult.OK )
            {
                employesListControl.AddEmploye(addForm.Employee);
            }
        }

        private void EmployesListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            IList<IEmployee> employees = employesListControl.Employees;
            DataSerializer.SerializeBin("employesList.sdb", ref employees);
        }

        private void removeMenuItem_Click(object sender, EventArgs e)
        {
            employesListControl.RemoveCurrent();
        }
    }
}
