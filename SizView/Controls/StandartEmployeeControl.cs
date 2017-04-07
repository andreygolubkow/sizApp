namespace SizView.Controls
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;

    using Model.Employee;
    using Model.Professions;

    public partial class StandartEmployeeControl : UserControl
    {
        private StandartEmployee _employee;

        private IList<IProfession> _professions;

        public StandartEmployeeControl()
        {
            dateOfEmploymentPicker.Value = DateTime.Today;
            dateChangePositionPicker.Value = DateTime.Today;
            dateChangePositionPicker.Checked = false;
            _professions = new List<IProfession>();
            _employee = new StandartEmployee();
            InitializeComponent();
        }

        public StandartEmployee Employee
        {
            get
            {
                try
                {
                    _employee = new StandartEmployee
                                {
                                    Surname = surnameTextBox.Text,
                                    Name = nameTextBox.Text,
                                    MiddleName = middleNameTextBox.Text,
                                    PersonnelNumber = personnelNumberTextBox.Text,
                                    StructuralUnit = structuralUnitTextBox.Text,
                                    Profession = (IProfession)iProfessionBindingSource.Current,
                                    DateOfEmployment = dateOfEmploymentPicker.Value,
                                    Sex = (Sex)sexComboBox.SelectedIndex,
                                    Growth = Convert.ToDouble(growthTextBox.Text),
                                    ClothingSize = clothingSizeTextBox.Text,
                                    ShoeSize = shoeSizeTextBox.Text,
                                    HeadgearSize = headgearSizeTextBox.Text,
                                    GasmaskSize = gasmaskSizeTextBox.Text,
                                    RespiratorSize = respiratorSizeTextBox.Text,
                                    GauntletsSize = gauntletsSizeTextBox.Text,
                                    GlovesSize = glovesSizeTextBox.Text
                                };
                    if (dateChangePositionPicker.Checked)
                    {
                        _employee.DateChangePosition = dateChangePositionPicker.Value;
                    }
                    else
                    {
                        _employee.DateChangePosition = null;
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                return _employee;
            }
            set
            {
                if ( value != null )
                {
                    _employee = value;
                    surnameTextBox.Text = _employee.Surname;
                    nameTextBox.Text = _employee.Name;
                    middleNameTextBox.Text = _employee.MiddleName;
                    personnelNumberTextBox.Text = _employee.PersonnelNumber;
                    structuralUnitTextBox.Text = _employee.StructuralUnit;
                    professionComboBox.SelectedIndex =
                            _professions.IndexOf(_professions.Where(p => p.Id == _employee.Profession.Id).FirstOrDefault());
                    dateOfEmploymentPicker.Value = _employee.DateOfEmployment;
                    if ( _employee.DateChangePosition == null )
                    {
                        dateChangePositionPicker.Checked = false;
                        dateChangePositionPicker.Value = _employee.DateChangePosition.Value;
                    }
                    else
                    {
                        dateChangePositionPicker.Checked = true;
                        dateChangePositionPicker.Value = _employee.DateChangePosition.Value;
                    }
                    sexComboBox.SelectedIndex = (int)_employee.Sex;
                    growthTextBox.Text = Convert.ToString(_employee.Growth, CultureInfo.InvariantCulture);
                    clothingSizeTextBox.Text = _employee.ClothingSize;
                    shoeSizeTextBox.Text = _employee.ShoeSize;
                    headgearSizeTextBox.Text = _employee.HeadgearSize;
                    gasmaskSizeTextBox.Text = _employee.GasmaskSize;
                    respiratorSizeTextBox.Text = _employee.RespiratorSize;
                    gauntletsSizeTextBox.Text = _employee.GauntletsSize;
                    glovesSizeTextBox.Text = _employee.GlovesSize;
                }
                else
                {
                    _employee = new StandartEmployee();
                }
            }
        }

        public IList<IProfession> Professions
        {
            get
            {
                return _professions;
            }
            set
            {
                _professions = value ?? new List<IProfession>();
                iProfessionBindingSource.DataSource = _professions;
            }
        }
    }
}
