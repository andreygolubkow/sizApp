using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SizView
{
    using Model.Employee;
    using Model.Professions;
    using Model.Project;

    using Tools;

    public partial class MainForm : Form
    {

        private List<IEmployee> _employeesList;

        private List<IProfession> _professionsList;

        private IProject _project;

        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            LoadEmployes();
            LoadProfessions();
            LoadProject();
        }

        public void SaveData()
        {
            SaveEmployes();
            SaveProject();
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
            }
            catch (Exception)
            {
                _project = new Project();
            }
        }


        private void SaveProject()
        {
            try
            {
                DataSerializer.SerializeBin("Project.sdb", ref _project);
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
                DataSerializer.SerializeBin("employesList.sdb", ref _employeesList);
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

        private void informationMenuItem_Click(object sender, EventArgs e)
        {
            if ( _project is Project )
            {
                var infoForm = new InformationForm(((Project)_project).ProjectInformation);
                if ( infoForm.ShowDialog() == DialogResult.OK )
                {
                    infoForm
                }
            }
            

        }
    }
}
