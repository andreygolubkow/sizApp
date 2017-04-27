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
                correctEquipmentAdapterBindingSource.DataSource = newList;
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

        private void employeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectediProfessionBindingSource.Clear();
            var employee = (FullNameEmployeeAdapter)fullNameEmployeeAdapterBindingSource.Current;
            selectediProfessionBindingSource.Add(employee.Employee.Profession);
        }

        private void professionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var profession = (IProfession)iProfessionBindingSource.Current;
            iEquipmentBindingSource.DataSource = profession.Equipments;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            selectediProfessionBindingSource.Add(iProfessionBindingSource.Current);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            selectediProfessionBindingSource.RemoveCurrent();
        }

        private void generateIssueButton_Click(object sender, EventArgs e)
        {
            var list = new List<CorrectEquipmentAdapter>();
            foreach (IProfession profession in selectediProfessionBindingSource)
            {
                foreach (IEquipment item in profession.Equipments)
                {
                    list.Add(new CorrectEquipmentAdapter(item,Zone));
                }
            }
            completeListBindingSource.DataSource = list;
        }

        private void addAdditionalSizButton_Click(object sender, EventArgs e)
        {

        }
    }
}
