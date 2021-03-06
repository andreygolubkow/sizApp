﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SizView
{
    using Model.Employee;
    using Model.Equipments;
    using Model.Professions;
    using Model.Project;
    using Model.Regions;
    using Model.Zones;

    using Tools;

    public partial class MainForm : Form
    {

        private List<IEmployee> _employeesList;

        private List<IProfession> _professionsList;

        private IProject _project;

        private List<IRegion> _regionsList;

        private List<IEquipment> _equipments;

        private SizViewForm _sizViewForm;

        public MainForm()
        {
            InitializeComponent();

            LoadData();
            _sizViewForm = new SizViewForm(((Project)_project).ProjectInformation.Region.Zone);
        }

        private void LoadData()
        {
            LoadEmployes();
            LoadProfessions();
            LoadProject();
            LoadRegions();
            LoadEquipments();
        }

        private void SaveData()
        {
            SaveEmployes();
            SaveProject();
        }

        private void LoadEquipments()
        {
            try
            {
                DataSerializer.DeserializeBin("equipmentsList.sdb", ref _equipments);
            }
            catch (Exception)
            {
                _equipments = new List<IEquipment>();
            }
        }
        private void LoadEmployes()
        {
            try
            {
                DataSerializer.DeserializeBin("employesList.sdb", ref _employeesList);
            }
            catch (Exception)
            {
                _employeesList = new List<IEmployee>();
            }
        }

        private void LoadProfessions()
        {
            try
            {
                DataSerializer.DeserializeBin("professionsList.sdb", ref _professionsList);
            }
            catch (Exception)
            {
                _professionsList = new List<IProfession>();
            }
        }

        private void LoadProject()
        {
            try
            {
                DataSerializer.DeserializeBin("Project.sdb", ref _project);
                var proj = (Project)_project;
                sizListControl.Zone = proj.ProjectInformation.Region.Zone ?? new StandartZone(0,0,"");
                sizListControl.IssueRecords = proj.ProjectJournal;
            }
            catch (Exception)
            {
                var project = new Project
                                  {
                                      ProjectInformation = null
                                  };
                _project = new Project();
            }
        }

        private void LoadRegions()
        {
            try
            {
                DataSerializer.DeserializeBin("regionsList.sdb", ref _regionsList);
            }
            catch (Exception)
            {
                _regionsList = new List<IRegion>();
            }
        }


        private void SaveProject()
        {
            try
            {
                var proj = (Project)_project;
                proj.ProjectJournal = sizListControl.IssueRecords;
                DataSerializer.SerializeBin("Project.sdb", _project);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка при сохранении проекта:" + exception.Message);
            }
        }

        private void SaveEmployes()
        {
            try
            {
                DataSerializer.SerializeBin("employesList.sdb",  _employeesList);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка при сохранении базы работников:"+exception.Message);
            }
        }

        private void employesMenuItem_Click(object sender, EventArgs e)
        {
            var employesForm = new EmployesListForm(_employeesList,_professionsList);
            employesForm.ShowDialog();
            _employeesList = employesForm.Employees;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private void InformationMenuItemClick(object sender, EventArgs e)
        {
            InformationForm infoForm = (_project as Project).ProjectInformation.Region == null ? new InformationForm(null, _regionsList) : new InformationForm(((Project)_project).ProjectInformation, _regionsList);
            if ( infoForm.ShowDialog() == DialogResult.OK )
            {
                ((Project)_project).ProjectInformation = infoForm.Information;
            }
        }

        private void newIssueMenuItem_Click(object sender, EventArgs e)
        {
            var issueForm = new IssueRecordAddForm
                                {
                                    Employees = _employeesList,
                                    Zone = ((Project)_project).ProjectInformation.Region.Zone,
                                    Equipments = _equipments,
                                    Professions = _professionsList
                                };
            issueForm.ShowDialog();
            if ( issueForm.DialogResult != DialogResult.OK )
            {
                return;
            }

            List<IssueRecord> list = sizListControl.IssueRecords;
            list.Add(issueForm.Issue);
            sizListControl.Zone = ((Project)_project).ProjectInformation.Region.Zone;
            sizListControl.IssueRecords = list;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void showInfoMenuItem_Click(object sender, EventArgs e)
        {
            _sizViewForm.Show();
            if (sizListControl.CurrentRecord != null)
            {
                _sizViewForm.LoadIsuue(sizListControl.CurrentRecord);
            }
        }

        private void SizListControlCurrentChanged(object sender, EventArgs e)
        {
            if ( sizListControl.CurrentRecord != null )
            {
                _sizViewForm.LoadIsuue(sizListControl.CurrentRecord);
                actualMenuItem.Checked = sizListControl.IssueActive;
            }
        }

        private void actualMenuItem_Click(object sender, EventArgs e)
        {
            sizListControl.IssueActive = actualMenuItem.Checked;
        }
    }
}
