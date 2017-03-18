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
    public partial class workerAdd : Form
    {
        public workerAdd()
        {
            InitializeComponent();
        }

        private void sizSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var row = new DataGridViewRow();
            row.CreateCells(sizGridView);
            row.SetValues("Перчатки", "5", "3 месяца");
            sizGridView.Rows.Add(row);
            row = new DataGridViewRow();
            row.CreateCells(sizGridView);
            row.SetValues("Маска", "5", "1 месяц");
            sizGridView.Rows.Add(row);
            row = new DataGridViewRow();
            row.CreateCells(sizGridView);
            row.SetValues("Сапоги", "2", "12 месяцев");
            sizGridView.Rows.Add(row);

            row = new DataGridViewRow();
            row.CreateCells(allSizGridView);
            row.SetValues("Перчатки", "5", "3 месяца", "");
            allSizGridView.Rows.Add(row);
            row = new DataGridViewRow();
            row.CreateCells(allSizGridView);
            row.SetValues("Маска", "5", "1 месяца", "");
            allSizGridView.Rows.Add(row);
            row = new DataGridViewRow();
            row.CreateCells(allSizGridView);
            row.SetValues("Сапоги", "2", "12 месяца", "");
            allSizGridView.Rows.Add(row);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sizList.Items.Add("Плотник");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var row = new DataGridViewRow();
            row.CreateCells(allSizGridView);
            row.SetValues("Каска", "1", "3 месяца","Рекомендация комиссии");
            allSizGridView.Rows.Add(row);
        }
    }
}
