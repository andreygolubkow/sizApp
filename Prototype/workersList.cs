using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    public partial class workersList : Form
    {
        public workersList()
        {
            InitializeComponent();
            var row = new DataGridViewRow();
            row.CreateCells(workersListView);
            row.SetValues("Иванов", "Петр", "Плотник", "02.03.2017", "02.05.2017");
            workersListView.Rows.Add(row);
            row = new DataGridViewRow();
            row.CreateCells(workersListView);
            row.SetValues("Голубков", "Андрей", "Строитель", "02.03.2017", "20.03.2017");
            row.DefaultCellStyle.BackColor = Color.Crimson;
            workersListView.Rows.Add(row);
            row = new DataGridViewRow();
            row.CreateCells(workersListView);
            row.SetValues("Семенов", "Владимир", "Плотник", "02.03.2017", "07.09.2017");
            workersListView.Rows.Add(row);
            row = new DataGridViewRow();
            row.CreateCells(workersListView);
            row.SetValues("Марков", "Иван", "Строитель", "02.03.2017", "02.04.2017");
            row.DefaultCellStyle.BackColor = Color.DarkOrange;
            workersListView.Rows.Add(row);
            ///////////////////////////////////////////
            row = new DataGridViewRow();
            row.CreateCells(sizGridView);
            row.SetValues("Костюм", "02.03.2017", "30.03.2017");
            sizGridView.Rows.Add(row);
            row = new DataGridViewRow();
            row.CreateCells(sizGridView);
            row.SetValues("Каска", "02.03.2017", "20.03.2017");
            row.DefaultCellStyle.BackColor = Color.Crimson;
            sizGridView.Rows.Add(row);
            row = new DataGridViewRow();
            row.CreateCells(sizGridView);
            row.SetValues("Комплект перчаток", "02.03.2017", "10.03.2017");
            row.DefaultCellStyle.BackColor = Color.DarkOrange;
            sizGridView.Rows.Add(row);
            row = new DataGridViewRow();
            row.CreateCells(sizGridView);
            row.SetValues("Ботинки", "02.03.2017", "20.09.2017");
            sizGridView.Rows.Add(row);
        }

        private void workersList_Load(object sender, EventArgs e)
        {

        }

        private void workersListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void workersListView_Click(object sender, EventArgs e)
        {
            detalisGroupBox.Visible = true;
        }

        private void giveSizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addForm = new workerAdd();
            addForm.ShowDialog();
        }
    }
}
