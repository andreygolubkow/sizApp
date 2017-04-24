﻿using System.Windows.Forms;

namespace SizView.Controls
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;

    using Model.Equipments;
    using Model.Project;
    using Model.Zones;

    public partial class SizListControl : UserControl
    {
        private List<IssueRecord> _issueRecords;

        public SizListControl()
        {
            InitializeComponent();

        }

        [DefaultValue(null)]
        public List<IssueRecord> IssueRecords
        {
            set
            {
                if ( value == null )
                {
                    _issueRecords = new List<IssueRecord>();
                }
                else
                {
                    _issueRecords = value;
                }
                InitGridView();
            }
            get
            {
                return _issueRecords;
            }
        }

        public IZone Zone { get; set; }

        private void InitGridView()
        {
            foreach (var record in _issueRecords)
            {
                string surname = Convert.ToString(record.Employee.Surname);
                string name = Convert.ToString(record.Employee.Name);
                string middleName = Convert.ToString(record.Employee.MiddleName);
                string startDate;
                {
                    DateTime issueDateTime = record.Resources[0].IssueDate;
                    foreach (var resource in record.Resources)
                    {
                        if ( resource.IssueDate < issueDateTime )
                        {
                            issueDateTime = resource.IssueDate;
                        }
                    }
                    startDate = Convert.ToString(issueDateTime.Date, CultureInfo.InvariantCulture);
                }
                string endDate;
                {
                    DateTime minEndDateTime = GetEndDateTime(record.Resources[0].Equipment, startDate);
                    foreach (var resource in record.Resources)
                    {
                        if ( minEndDateTime > GetEndDateTime(resource.Equipment, startDate) )
                        {
                            minEndDateTime = GetEndDateTime(resource.Equipment, startDate);
                        }
                    }
                    endDate = Convert.ToString(minEndDateTime, CultureInfo.InvariantCulture);
                }
                DataGridViewRow row = new DataGridViewRow();
                row.Cells[0].Value = surname;
                row.Cells[1].Value = name;
                row.Cells[2].Value = middleName;
                row.Cells[3].Value = startDate;
                row.Cells[4].Value = endDate;
                if ((Convert.ToDateTime(endDate).Date - DateTime.Today.Date).TotalDays < 7)
                {
                    row.InheritedStyle.BackColor = Color.Salmon;
                }
                else
                if ((Convert.ToDateTime(endDate).Date - DateTime.Today.Date).TotalDays < 30 )
                {
                    row.InheritedStyle.BackColor = Color.BurlyWood;
                }
                issueGridView.Rows.Add(row);
            }
        }

        private DateTime GetEndDateTime(IEquipment equipmentObject,string startDate)
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
    }
}