using System.Windows.Forms;

using Model.Project;
using Model.Zones;

using  Tools;

namespace SizView
{
    public partial class SizViewForm : Form
    {
        public SizViewForm(IZone zone)
        {
            InitializeComponent();
            resourceView.Zone = zone;
        }

        public void LoadIsuue(IssueRecord record)
        {
            resourceView.Resources = record.Resources;
            numLabel.Text = record.Employee.PersonnelNumber;
            structuralUnit.Text = record.Employee.StructuralUnit;
            professionLabel.Text = record.Employee.Profession.Name;
            Text = record.Employee.Surname+" "+record.Employee.Name+ " - Информация";
        }

        private void closeButton_Click(object sender, System.EventArgs e)
        {
            Hide();
        }
    }
}
