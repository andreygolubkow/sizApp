using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Model.Zones;

namespace ConfiguratorView
{
    public partial class MainForm : Form
    {
        //Управление поясами
        private List<IZone> _zonesList;
        private int _zoneSelectedId;
        /////////////////////////////////
        
        public MainForm()
        {
            InitializeComponent();
            try
            {
                DataSerializer.DeserializeBin("zonesList.sdb",ref _zonesList);
            }
            catch
            {
                _zonesList = new List<IZone>();
            }
            iZoneBindingSource.DataSource = _zonesList;
            _zoneSelectedId = -1;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AddZoneButtonClick(object sender, EventArgs e)
        {
            try
            {
                int id = _zonesList.Count>0? _zonesList.Max(zone => zone.Id) + 1:0;
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

        private void zonesGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _zoneSelectedId = ((IZone)iZoneBindingSource.Current).Id;
            zoneNumTextBox.Text = Convert.ToString(((IZone)iZoneBindingSource.Current).Num);
            zoneAsStringTextBox.Text = ((IZone)iZoneBindingSource.Current).AsString;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataSerializer.SerializeBin("zonesList.sdb",ref _zonesList);
        }
    }
}
