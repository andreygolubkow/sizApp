using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SizView.Controls
{
    using Model.Employee;

    public partial class EmployesListControl : UserControl
    {
        private IList<IEmployee> _employees;

        public EmployesListControl()
        {
            InitializeComponent();
            _employees = new List<IEmployee>();
        }

        public IList<IEmployee> Employees
        {
            get
            {
                return _employees;
            }

            set
            {
                if (value == null)
                {
                    _employees = new List<IEmployee>();
                    iEmployeeBindingSource.DataSource = _employees;
                }
                else
                {
                    _employees = value;
                    iEmployeeBindingSource.DataSource = _employees;
                }
            }
        }

        public IEmployee CurrentEmployee => (IEmployee)iEmployeeBindingSource.Current;

        public void AddEmploye(IEmployee employee)
        {
            if ( employee != null )
            {
                iEmployeeBindingSource.Add(employee);
            }
        }

        public void RemoveCurrent()
        {
            if ( iEmployeeBindingSource.Current != null )
            {
                iEmployeeBindingSource.RemoveCurrent();
            }
        }
    }
}
