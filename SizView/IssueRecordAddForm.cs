using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SizView
{
    using Model.Employee;
    using Model.Equipments;
    using Model.Professions;
    using Model.Zones;

    using Tools;

    public partial class IssueRecordAddForm : Form
    {
        public IssueRecordAddForm()
        {
            InitializeComponent();
        }

        public List<IEmployee> Employees
        {
            set
            {
                List<FullNameEmployeeAdapter> listAdapt = FullNameEmployeeAdapter.AdaptEmployeesList(value);
                fullNameEmployeeAdapterBindingSource.DataSource = listAdapt;
            }
        }

        public List<IEquipment> Equipments
        {
            set
            {
                List<CorrectEquipmentAdapter> newList = CorrectEquipmentAdapter.AdaptEquipmentList(value,Zone);
                iEquipmentBindingSource.DataSource = newList;
            }
        }

        public IZone Zone { get; set; }

        public List<IProfession> Professions
        {
            set
            {
                iProfessionBindingSource.DataSource = value;
            }
        }
    }
}
