using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace SizView.Controls
{
    using Model.Employee;

    public partial class EmployesListControl : UserControl
    {
        public delegate void OnSelectMethod();

        /// <summary>
        /// Выбор работника в таблице.
        /// </summary>
        public event OnSelectMethod onSelectEmployee;

        private IList<IEmployee> _employees;

        public EmployesListControl()
        {
            InitializeComponent();
            _employees = new List<IEmployee>();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DefaultValue(null)]
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

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DefaultValue(null)]
        public IEmployee CurrentEmployee
        {
            get
            {
                return (IEmployee)iEmployeeBindingSource.Current;
            }
            set
            {
                int index = _employees.IndexOf((IEmployee)iEmployeeBindingSource.Current);
                _employees[index] = value;
                iEmployeeBindingSource[iEmployeeBindingSource.Position] = _employees[index];
            }
        }

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


        public bool SearchBox
        {
            get
            {
                return searchGroupBox.Visible;
            }
            set
            {
                    searchGroupBox.Visible = value;
            }
        }

        private void employesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ( iEmployeeBindingSource.Current != null )
            {
                onSelectEmployee?.Invoke();
            }
            
        }
    }
}
