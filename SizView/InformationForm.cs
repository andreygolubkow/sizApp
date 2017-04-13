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
    using Model.Project;

    public partial class InformationForm : Form
    {

        public InformationForm(Information information)
        {
            InitializeComponent();
            if ( information != null )
            {
                organizationFullNameTextBox.Text = information.OrganizationFullName;
                organizationShortNameTextBox.Text = information.OrganizaionShortName;
                leaderFullNameTextBox.Text = information.LeaderFullName;
                leaderPositionTextBox.Text = information.LeaderPosition;
                if ( information.LeaderFullName == information.HeadPerson )
                {
                    leaderRadioButton.Checked = true;
                    otherTextBox.Enabled = false;
                }
                else
                {
                    otherRadioButton.Checked = true;
                    otherTextBox.Text = information.HeadPerson;
                    otherTextBox.Enabled = true;
                }
            }
        }

        public Information Information
        {
            get
            {
                var info = new Information();
                info.OrganizationFullName = organizationFullNameTextBox.Text;
                info.OrganizaionShortName = organizationShortNameTextBox.Text;
                info.LeaderFullName = leaderFullNameTextBox.Text;
                info.LeaderPosition = leaderPositionTextBox.Text;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void otherRadioButton_CheckedChanged(object sender, EventArgs e)
        {
                otherTextBox.Enabled = otherRadioButton.Checked;
        }

        private void leaderRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            otherTextBox.Enabled = otherRadioButton.Checked;
        }
    }
}
