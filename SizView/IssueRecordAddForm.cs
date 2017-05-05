namespace SizView
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    using Model.Employee;
    using Model.Equipments;
    using Model.Professions;
    using Model.Project;
    using Model.Zones;

    using Tools;

    public partial class IssueRecordAddForm : Form
    {
        private  IssueRecord _issue;

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
                List<CorrectEquipmentAdapter> newList = CorrectEquipmentAdapter.AdaptEquipmentList(value, Zone);
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

        public IssueRecord Issue => _issue;

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
                    list.Add(new CorrectEquipmentAdapter(item, Zone));
                }
            }

            completeListBindingSource.DataSource = list;
        }

        private void addAdditionalSizButton_Click(object sender, EventArgs e)
        {
            IEquipment inAdapterEquipment = ((CorrectEquipmentAdapter)correctEquipmentAdapterBindingSource.Current).GetEquipment();
            var equipment = new CorrectEquipmentAdapter(inAdapterEquipment, Zone)
                                {
                                    Notes = additionsTextBox.Text
                                };
            completeListBindingSource.Add(equipment);
        }

        private void completeSizGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IEquipment equipment = ((CorrectEquipmentAdapter)completeListBindingSource.Current).GetEquipment();
            editSizNameTextBox.Text = equipment.Name;
            if (!(equipment is CompositeEquipment))
            {
                editAdditionComboBox.Enabled = false;
                editApplySizButton.Enabled = false;
                return;
            }

            editAdditionComboBox.Enabled = true;
            editApplySizButton.Enabled = true;
            var compositeEquipment = equipment as CompositeEquipment;
            editEquipmentBindingSource.DataSource = new List<IEquipment>(compositeEquipment.EquipmentsList);


        }

        private void editRemoveSizButton_Click(object sender, EventArgs e)
        {
            completeListBindingSource.RemoveCurrent();
        }

        private void editApplySizButton_Click(object sender, EventArgs e)
        {
            var equipment = (IEquipment)editEquipmentBindingSource.Current;
            var adaptedEquipment = new CorrectEquipmentAdapter(equipment,Zone);
            completeListBindingSource.RemoveCurrent();
            completeListBindingSource.Add(adaptedEquipment);
        }

        private void newIssueRecordButton_Click(object sender, EventArgs e)
        {
            var record = new IssueRecord
                             {
                                 Employee = ((FullNameEmployeeAdapter)fullNameEmployeeAdapterBindingSource.Current).Employee
            };
            List<IProfession> professions = selectediProfessionBindingSource.List.Cast<IProfession>().ToList();
            List<Resource> resourcesList = (from eq in (List<CorrectEquipmentAdapter>)completeListBindingSource.DataSource
                                    select new Resource
                                               {
                                                   Additional = eq.Notes,
                                                   Count = eq.Count,
                                                   Equipment = eq.GetEquipment(),
                                                   IssueDate = DateTime.Now
                                               }).ToList();
            record.Resources = resourcesList;
            record.Professions = professions;
            _issue = record;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void IssueRecordAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
