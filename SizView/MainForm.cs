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
    using Model.Professions;

    using Tools;

    public partial class MainForm : Form
    {

        private List<IEmployee> _employeesList;

        private List<IProfession> _professionsList;
        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            LoadEmployes();
            LoadProfessions();
        }

        public void SaveData()
        {
            SaveEmployes();
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
    }
}
