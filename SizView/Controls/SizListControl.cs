using System.Windows.Forms;

namespace SizView.Controls
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;

    using Model.Equipments;
    using Model.Project;
    using Model.Zones;

    public partial class SizListControl : UserControl
    {
        public event EventHandler CurrentChanged;

        private List<IssueRecord> _issueRecords;

        public SizListControl()
        {
            InitializeComponent();
            _issueRecords = new List<IssueRecord>();
            CurrentRecord = null;
        }

        public IssueRecord CurrentRecord { get; private set; }

        public void UpdateList()
        {
            InitGridView();
        }

        [DefaultValue(false)]
        public bool IssueActive
        {
            get
            {
                if ( CurrentRecord != null )
                {
                    return CurrentRecord.Active;
                }
                return false;
            }
            set
            {
                if (issueGridView.SelectedRows.Count <= 0)
                {
                    return;
                }
                _issueRecords[issueGridView.SelectedRows[0].Index].Active = value;
            }
        }

        [DefaultValue(null)]
        public List<IssueRecord> IssueRecords
        {
            get => _issueRecords;

            set
            {
                _issueRecords = value ?? new List<IssueRecord>();
                InitGridView();
            }
        }

        [DefaultValue(null)]
        public IZone Zone { get; set; }

        private void InitGridView()
        {
            issueGridView.Rows.Clear();
            foreach (IssueRecord record in _issueRecords)
            {
                string surname = Convert.ToString(record.Employee.Surname);
                string name = Convert.ToString(record.Employee.Name);
                string middleName = Convert.ToString(record.Employee.MiddleName);
                string professionName = record.Professions.FirstOrDefault()?.Name;
                string startDate;
                DateTime issueDateTime = record.Resources.FirstOrDefault().IssueDate;
                {
                    
                    foreach (Resource resource in record.Resources)
                    {
                        if ( resource.IssueDate < issueDateTime )
                        {
                            issueDateTime = resource.IssueDate;
                        }
                    }

                    startDate = Convert.ToString(issueDateTime.Date, CultureInfo.CurrentCulture);
                }

                string endDateS;
                DateTime minEndDateTime = GetEndDateTime(record.Resources[0].Equipment, issueDateTime);
                {
                    
                    foreach (Resource resource in record.Resources)
                    {
                        if ( minEndDateTime > GetEndDateTime(resource.Equipment, issueDateTime) )
                        {
                            minEndDateTime = GetEndDateTime(resource.Equipment, issueDateTime);
                        }
                    }

                    endDateS = Convert.ToString(minEndDateTime, CultureInfo.CurrentCulture);
                }
                var row = new DataGridViewRow();
                row.CreateCells(issueGridView);
                row.SetValues(surname, name, middleName, professionName, startDate, endDateS);
                if ( record.Active )
                {
                    if ( (minEndDateTime - DateTime.Today).TotalDays < 7 )
                    {
                        row.DefaultCellStyle.BackColor = Color.Salmon;
                    }
                    else if ( (minEndDateTime - DateTime.Today).TotalDays < 30 )
                    {
                        row.DefaultCellStyle.BackColor = Color.BurlyWood;
                    }
                }
                issueGridView.Rows.Add(row);
            }
        }

        private DateTime GetEndDateTime(IEquipment equipmentObject,DateTime startDate)
        {
            if (equipmentObject is ByZoneEquipment)
            {
                var equipment = (ByZoneEquipment)equipmentObject;
                double count = 0;
                foreach (KeyValuePair<IZone, double> zone in equipment.CountByZone)
                {
                    if (zone.Key.Id == Zone.Id)
                    {
                        count = zone.Value;
                        break;
                    }
                }

                double days = 365 / count;
                DateTime startDateTime = Convert.ToDateTime(startDate);
                DateTime endDateTime = startDateTime.AddDays(days);
                return endDateTime;
            }

            if (equipmentObject is PerYearEquipment)
            {
                var equipment = (PerYearEquipment)equipmentObject;
                double count = 0;
                count = equipment.CountPerYear;
                double days = 365 / count;
                DateTime startDateTime = Convert.ToDateTime(startDate);
                DateTime endDateTime = startDateTime.AddDays(days);
                return endDateTime;
            }

            return (Convert.ToDateTime(startDate)).AddYears(1000);
        }

        protected virtual void OnCurrentChanged()
        {
            CurrentChanged?.Invoke(this,new EventArgs());
        }

        private void IssueGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ( issueGridView.SelectedRows.Count <= 0 )
            {
                return;
            }
            CurrentRecord = _issueRecords[issueGridView.SelectedRows[0].Index];
            OnCurrentChanged();
        }
    }
}
