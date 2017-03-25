using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Model.Regions;
using Model.Zones;

namespace ConfiguratorView
{
    public partial class MainForm : Form
    {
        //Управление поясами
        private List<IZone> _zonesList;
        private int _zoneSelectedId;
        /////////////////////////////////

        //Управление регионами
        private List<IRegion> _regionsList;
        private int _regionSelectedId;
        /////////////////////////////////

        private int MaxZoneId()
        {
            int max = 0;
            foreach (IZone item in _zonesList)
            {
                if (item.Id > max)
                {
                    max = item.Id;
                }
            }
            return max;
        }

        private int MaxRegionId()
        {
            int max = 0;
            foreach (IRegion item in _regionsList)
            {
                if (item.Id > max)
                {
                    max = item.Id;
                }
            }
            return max;
        }

        private void LoadZone()
        {
            try
            {
                DataSerializer.DeserializeBin("zonesList.sdb", ref _zonesList);
            }
            catch
            {
                _zonesList = new List<IZone>();
            }
            iZoneBindingSource.DataSource = _zonesList;
            _zoneSelectedId = -1;
        }

        private void LoadRegion()
        {
            try
            {
                DataSerializer.DeserializeBin("regionsList.sdb", ref _regionsList);
            }
            catch
            {
                _regionsList = new List<IRegion>();
            }
            iRegionBindingSource.DataSource = _regionsList;
            _regionSelectedId = -1;
        }
        public MainForm()
        {
            InitializeComponent();
            LoadZone();
            LoadRegion();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AddZoneButtonClick(object sender, EventArgs e)
        {
            try
            {
                int id = MaxZoneId() + 1;

                iZoneBindingSource.Add(new StandartZone(id, Convert.ToInt32(zoneNumTextBox.Text), zoneAsStringTextBox.Text));
                zoneNumTextBox.Clear();
                zoneAsStringTextBox.Clear();
                _zoneSelectedId = -1;
            }
            catch ( Exception exception )
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void RemoveZoneButtonClick(object sender, EventArgs e)
        {
            try
            {
                iZoneBindingSource.RemoveCurrent();
                zoneNumTextBox.Clear();
                zoneAsStringTextBox.Clear();
                _zoneSelectedId = -1;
            }
            catch ( Exception exception )
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ApplyZoneButtonClick(object sender, EventArgs e)
        {
            if ( _zoneSelectedId <= -1 )
            {
                MessageBox.Show("Выберите элемент для правки");
                return;
            }
            int index = _zonesList.IndexOf((IZone)iZoneBindingSource.Current);
            _zonesList[index] = new StandartZone(_zoneSelectedId, Convert.ToInt32(zoneNumTextBox.Text), zoneAsStringTextBox.Text);
            iZoneBindingSource[iZoneBindingSource.Position] = _zonesList[index];
        }

        private void iZoneBindingSource_CurrentChanged(object sender, EventArgs e)
        {
           
        }
        

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataSerializer.SerializeBin("zonesList.sdb",ref _zonesList);
            DataSerializer.SerializeBin("regionsList.sdb", ref _regionsList);
        }

        private void AdditionalRegionCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            regionAdditionTextBox.Enabled = additionalRegionCheckBox.Checked;
        }

        private void AddRegionButtonClick(object sender, EventArgs e)
        {
            try
            {
                int id = MaxRegionId()+1;
                if ( additionalRegionCheckBox.Checked )
                {
                    iRegionBindingSource.Add(new NonStandartRegion(id, regionNameTextBox.Text,regionAdditionTextBox.Text
                        ,(IZone)regionZoneComboBox.SelectedItem));
                }
                else
                {
                    iRegionBindingSource.Add(new StandartRegion(id, regionNameTextBox.Text, (IZone)regionZoneComboBox.SelectedItem));
                }
                regionNameTextBox.Clear();
                regionAdditionTextBox.Clear();
                regionZoneComboBox.SelectedIndex = -1;
                _regionSelectedId = -1;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void RemoveRegionButtonClick(object sender, EventArgs e)
        {
            try
            {
                iRegionBindingSource.RemoveCurrent();
                regionAdditionTextBox.Clear();
                regionNameTextBox.Clear();
                regionZoneComboBox.SelectedIndex = -1;
                _regionSelectedId = -1;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void RegionsGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _regionSelectedId = ((IRegion)iRegionBindingSource.Current).Id;
                regionNameTextBox.Text = ((IRegion)iRegionBindingSource.Current).Name;
                var zone = _zonesList.FirstOrDefault(a => a.Id == ((IRegion)iRegionBindingSource.Current).Zone.Id);
                regionZoneComboBox.SelectedIndex = iZoneBindingSource.IndexOf(zone);

                if (iRegionBindingSource.Current is NonStandartRegion)
                {
                    additionalRegionCheckBox.Checked = true;
                    regionAdditionTextBox.Text = ((NonStandartRegion)iRegionBindingSource.Current).Addition;
                }
                else
                {
                    additionalRegionCheckBox.Checked = false;
                    regionAdditionTextBox.Clear();
                }
            }
            catch ( Exception exception )
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private void ZonesGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            _zoneSelectedId = ((IZone)iZoneBindingSource.Current).Id;
            zoneNumTextBox.Text = Convert.ToString(((IZone)iZoneBindingSource.Current).Num);
            zoneAsStringTextBox.Text = ((IZone)iZoneBindingSource.Current).AsString;
        }

        private void ApplyRegionButtonClick(object sender, EventArgs e)
        {
            if (_regionSelectedId <= -1)
            {
                MessageBox.Show("Выберите элемент для правки");
                return;
            }
            int index = _regionsList.IndexOf((IRegion)iRegionBindingSource.Current);
            if ( additionalRegionCheckBox.Checked )
            {
                _regionsList[index] = new NonStandartRegion(_regionSelectedId,regionNameTextBox.Text,regionAdditionTextBox.Text,(IZone)regionZoneComboBox.SelectedItem);
            }
            else
            {
                _regionsList[index] = new StandartRegion(_regionSelectedId, regionNameTextBox.Text, (IZone)regionZoneComboBox.SelectedItem);
            }
            iRegionBindingSource[iRegionBindingSource.Position] = _regionsList[index];
        }
    }
}
