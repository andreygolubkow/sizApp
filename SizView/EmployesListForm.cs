using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tools;

namespace SizView
{
    using System.Linq;

    using Model.Employee;
    using Model.Professions;

    public partial class EmployesListForm : Form
    {
        private IList<IEmployee> _employees;

        private IList<IProfession> _professions;
        public EmployesListForm(List<IEmployee> employeesList,List<IProfession>  professions)
        {
            InitializeComponent();
            var empList = employeesList;
            employesListControl.Employees = empList;
            _professions = professions;
        }

        private void EmployesForm_Load(object sender, EventArgs e)
        {

        }

        private void addMenuItem_Click(object sender, EventArgs e)
        {
            int id = employesListControl.Employees.Select(item => item.Id).Concat(new[]
                                                                  {
                                                                      0
                                                                  }).Max();
            var addForm = new EmployeeForm(id+1,(List<IProfession>)_professions);
            if ( addForm.ShowDialog() == DialogResult.OK )
            {
                employesListControl.AddEmploye(addForm.Employee);
            }
        }

        private void EmployesListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _employees = employesListControl.Employees;
        }

        public List<IEmployee> Employees => (List<IEmployee>)_employees;

        private void removeMenuItem_Click(object sender, EventArgs e)
        {
            employesListControl.RemoveCurrent();
        }

        private void editMenuItem_Click(object sender, EventArgs e)
        {
            var addForm = new EmployeeForm(employesListControl.CurrentEmployee, (List<IProfession>)_professions);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                employesListControl.CurrentEmployee = addForm.Employee;
            }
        }

        private void searchMenuItem_Click(object sender, EventArgs e)
        {
            employesListControl.SearchBox = !employesListControl.SearchBox;
        }
    }
}
