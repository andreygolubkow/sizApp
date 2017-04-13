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
    using Model.Regions;

    public partial class InformationForm : Form
    {

        private List<IRegion> _regions;
        public InformationForm(Information information,List<IRegion> regions)
        {
            InitializeComponent();
            _regions = regions;
            iRegionBindingSource.DataSource = _regions;
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
                cityTextBox.Text = information.City;

                int regionId = information.Region.Id;
                zoneComboBox.SelectedIndex = _regions.IndexOf(_regions.Where(p => p.Id == regionId).FirstOrDefault());
            }

            DialogResult = DialogResult.Cancel;
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
                info.HeadPerson = leaderRadioButton.Checked ? info.LeaderFullName : otherTextBox.Text;
                info.City = cityTextBox.Text;
                info.Region = (IRegion)iRegionBindingSource.Current;
                return info;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void otherRadioButton_CheckedChanged(object sender, EventArgs e)
        {
                otherTextBox.Enabled = otherRadioButton.Checked;
        }

        private void leaderRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            otherTextBox.Enabled = otherRadioButton.Checked;
        }

        private void zoneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void iRegionBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (iRegionBindingSource.Current is NonStandartRegion)
            {
                additionalTextBox.Text = ((NonStandartRegion)iRegionBindingSource.Current).Addition;
            }
            else
            {
                additionalTextBox.Clear();
            }
            zoneStringTextBox.Text = ((IRegion)iRegionBindingSource.Current).Zone.AsString;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
