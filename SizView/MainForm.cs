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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void employesMenuItem_Click(object sender, EventArgs e)
        {
            var employesForm = new EmployesForm();
            employesForm.ShowDialog();
        }
    }
}
