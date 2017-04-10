using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Model.Equipments;
using Model.Professions;
using Model.Regions;
using Model.Zones;
using Tools;

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

        //Управление сизами
        private List<IEquipment> _equipmentsList;
        private int _equipmentSelectedId;
            //Список СИЗ для нескольких СИЗ
        private List<IEquipment> _sizEquipmentsList;
        //Словарь для сизов и поясов
  //      private IDictionary<IZone, double> _sizByZoneDictionary;
        ///////////////////////////
        
        //Управление профессиями
        private List<IProfession> _professionsList;
        private List<IEquipment> _professionEquipmentsList;
        private int _professionSelectedId;

        private int MaxZoneId()
        {
            return _zonesList.Select(item => item.Id).Concat(new[]
                                                             {
                                                                 0
                                                             }).Max();
        }

        private int MaxRegionId()
        {
            return _regionsList.Select(item => item.Id).Concat(new[]
                                                               {
                                                                   0
                                                               }).Max();
        }

        private int MaxEquipmentId()
        {
            return _equipmentsList.Select(item => item.Id).Concat(new[]
                                                                  {
                                                                      0
                                                                  }).Max();
        }

        private int MaxProfessionId()
        {
            return _professionsList.Select(item => item.Id).Concat(new[]
                                                                  {
                                                                      0
                                                                  }).Max();
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

        private void LoadEquipment()
        {
            try
            {
                DataSerializer.DeserializeBin("equipmentsList.sdb", ref _equipmentsList);
            }
            catch
            {
                _equipmentsList = new List<IEquipment>();
            }
            iEquipmentBindingSource.DataSource = _equipmentsList;
            //_sizByZoneDictionary = new Dictionary<IZone, double>();
            _equipmentSelectedId = -1;
        }

        private void LoadProfession()
        {
            try
            {
                DataSerializer.DeserializeBin("professionsList.sdb", ref _professionsList);
            }
            catch
            {
                _professionsList = new List<IProfession>();
            }
            iProfessionBindingSource.DataSource = _professionsList;
            _professionSelectedId = -1;
            _professionEquipmentsList = new List<IEquipment>();
            professionEquipmentBindingSource.DataSource = _professionEquipmentsList;

        }

        public MainForm()
        {
            InitializeComponent();
            LoadZone();
            LoadRegion();
            LoadEquipment();
            LoadProfession();
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
            DataSerializer.SerializeBin("equipmentsList.sdb", ref _equipmentsList);
            DataSerializer.SerializeBin("professionsList.sdb", ref _professionsList);
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

        private void SizAddButtonClick(object sender, EventArgs e)
        {
            int id = MaxEquipmentId() + 1;
            switch ( sizTypeComboBox.SelectedIndex )
            {
                case 0:
                    iEquipmentBindingSource.Add(new PerYearEquipment(id,
                                                                     sizPerYearNameTextBox.Text,
                                                                     Convert.ToDouble(sizPerYearCountTextBox.Text), sizPerYearUnitsTextBox.Text));
                    break;
                case 1:
                    iEquipmentBindingSource.Add(new StringCountEquipment(id,sizStringCountNameTextBox.Text,sizStringCountCountTextBox.Text,sizStringUnitsTextBox.Text));
                    break;
                case 2:
                    iEquipmentBindingSource.Add(new CompositeEquipment(id,
                                                                       sizCompositeEquipmentNameTextBox.Text,
                                                                       _sizEquipmentsList,""));
                    break;
                case 3:
                    //Конвертируем лист в дикшинари
                    var zonesDictionary =new Dictionary<IZone, double>(((List<ZonesWithItems>)zonesWithItemsBindingSource.DataSource).ToDictionary(zone => zone.GetZone(), zone => zone.Count));
                    iEquipmentBindingSource.Add(new ByZoneEquipment(id, sizByZoneNameTextBox.Text, zonesDictionary,sizByZoneUnitsTextBox.Text));
                    break;
            }
        }

        private void SizTypeComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            sizPerYearEquipmentGroupBox.Visible = sizTypeComboBox.SelectedIndex == 0;
            sizStringCountEquipmentGroupBox.Visible = sizTypeComboBox.SelectedIndex == 1;
            sizCompositeEquipmentGroupBox.Visible = sizTypeComboBox.SelectedIndex == 2;
            sizByZoneGroupBox.Visible = sizTypeComboBox.SelectedIndex == 3;
            sizApplyButton.Enabled = sizTypeComboBox.SelectedIndex != 2;

            if ( sizCompositeEquipmentGroupBox.Visible )
            {
                _sizEquipmentsList = new List<IEquipment>();
                List<IEquipment> equipments = _equipmentsList.ToList();
                sizCompositeEquipmentComboBox.DisplayMember = "Name";
                sizCompositeEquipmentComboBox.DataSource = equipments;
                sizCompositeEquipmentListBox.Items.Clear();

                



            }
        }

        private void SizRemoveButtonClick(object sender, EventArgs e)
        {
            try
            {
                iEquipmentBindingSource.RemoveCurrent();
                sizTypeComboBox.SelectedIndex = -1;
                _equipmentSelectedId = -1;
                sizStringCountCountTextBox.Clear();
                sizStringCountNameTextBox.Clear();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void SizGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            var zonesList = new List<ZonesWithItems>();
            if ( iEquipmentBindingSource.Current is StringCountEquipment )
            {
                _equipmentSelectedId = ((StringCountEquipment)iEquipmentBindingSource.Current).Id;
                sizStringCountNameTextBox.Text = ((StringCountEquipment)iEquipmentBindingSource.Current).Name;
                sizStringCountCountTextBox.Text = ((StringCountEquipment)iEquipmentBindingSource.Current).Count;
                sizStringUnitsTextBox.Text = ((StringCountEquipment)iEquipmentBindingSource.Current).Units;
                sizTypeComboBox.SelectedIndex = 1;
            } else if (iEquipmentBindingSource.Current is PerYearEquipment)
            {
                _equipmentSelectedId = ((PerYearEquipment)iEquipmentBindingSource.Current).Id;
                sizPerYearNameTextBox.Text = ((PerYearEquipment)iEquipmentBindingSource.Current).Name;
                sizPerYearCountTextBox.Text = Convert.ToString(((PerYearEquipment)iEquipmentBindingSource.Current).CountPerYear, CultureInfo.InvariantCulture);
                sizTypeComboBox.SelectedIndex = 0;
                sizPerYearUnitsTextBox.Text = ((PerYearEquipment)iEquipmentBindingSource.Current).Units;
            } else if ( iEquipmentBindingSource.Current is CompositeEquipment )
            {
                _equipmentSelectedId = ((CompositeEquipment)iEquipmentBindingSource.Current).Id;
                sizTypeComboBox.SelectedIndex = 2;
                sizCompositeEquipmentNameTextBox.Text = ((CompositeEquipment)iEquipmentBindingSource.Current).Name;
                _sizEquipmentsList = new List<IEquipment>(((CompositeEquipment)iEquipmentBindingSource.Current).EquipmentsList);
                sizCompositeEquipmentListBox.Items.Clear();
                foreach (IEquipment eq in _sizEquipmentsList)
                {
                    sizCompositeEquipmentListBox.Items.Add(eq.Name);
                }
            } else if ( iEquipmentBindingSource.Current is ByZoneEquipment )
            {
                _equipmentSelectedId = ((ByZoneEquipment)iEquipmentBindingSource.Current).Id;
                sizTypeComboBox.SelectedIndex = 3;
                sizByZoneNameTextBox.Text = ((ByZoneEquipment)iEquipmentBindingSource.Current).Name;
                sizByZoneUnitsTextBox.Text = ((ByZoneEquipment)iEquipmentBindingSource.Current).Units;
                //Конвертируем дикшинари в лист
                foreach (KeyValuePair<IZone, double> item in ((ByZoneEquipment)iEquipmentBindingSource.Current).CountByZone)
                {
                    var zone = new ZonesWithItems
                               {
                                   Count = item.Value
                               };
                    zone.SetZone(item.Key);
                    zonesList.Add(zone);
                }
                zonesWithItemsBindingSource.DataSource = zonesList;
            }

        }

        private void SizApplyButtonClick(object sender, EventArgs e)
        {

            if (_equipmentSelectedId <= -1)
            {
                MessageBox.Show("Выберите элемент для правки");
                return;
            }

            int index = _equipmentsList.IndexOf((IEquipment)iEquipmentBindingSource.Current);
            
            switch (sizTypeComboBox.SelectedIndex)
            {
                case 0:
                    _equipmentsList[index] = new PerYearEquipment(_equipmentSelectedId,
                                                                  sizPerYearNameTextBox.Text,
                                                                  Convert.ToDouble(sizPerYearCountTextBox.Text),sizPerYearUnitsTextBox.Text);
                    break;   
                case 1:
                    _equipmentsList[index] = new StringCountEquipment(_equipmentSelectedId, sizStringCountNameTextBox.Text, sizStringCountCountTextBox.Text,sizStringUnitsTextBox.Text);       
                    break;
                case 2:
                    _equipmentsList[index] = new CompositeEquipment(_equipmentSelectedId, sizCompositeEquipmentNameTextBox.Text, _sizEquipmentsList,"");
                    break;
                case 3:
                    var zonesDictionary = new Dictionary<IZone, double>(((List<ZonesWithItems>)zonesWithItemsBindingSource.DataSource).ToDictionary(zone => zone.GetZone(), zone => zone.Count));
                    _equipmentsList[index] = new ByZoneEquipment(_equipmentSelectedId, sizByZoneNameTextBox.Text, zonesDictionary,sizByZoneUnitsTextBox.Text);                    
                    break;
            }
            iEquipmentBindingSource[iEquipmentBindingSource.Position] = _equipmentsList[index];
        }

        private void SizPerYearCountTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            Validators.DoubleEnterValidate(e);
        }

        private void SizCompositeEquipmentAddButtonClick(object sender, EventArgs e)
        {
            var list = new List<IEquipment>((IList<IEquipment>)sizCompositeEquipmentComboBox.DataSource);
            IEquipment item = list[sizCompositeEquipmentComboBox.SelectedIndex];

            _sizEquipmentsList.Add(item);
            sizCompositeEquipmentListBox.Items.Clear();
            foreach (IEquipment eq in _sizEquipmentsList)
            {
                sizCompositeEquipmentListBox.Items.Add(eq.Name);
            }

        }

        private void SizCompositeEquipmentComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            _equipmentSelectedId = 0;
        }

        private void SizCompositeEquipmentRemoveButtonClick(object sender, EventArgs e)
        {
            if ( sizCompositeEquipmentListBox.SelectedIndex > -1 )
            {
                _sizEquipmentsList.RemoveAt(sizCompositeEquipmentListBox.SelectedIndex);
                sizCompositeEquipmentListBox.Items.Clear();
                foreach (IEquipment eq in _sizEquipmentsList)
                {
                    sizCompositeEquipmentListBox.Items.Add(eq.Name);
                }
            }
        }

        private void SizByZoneGroupBoxVisibleChanged(object sender, EventArgs e)
        {
            if ( sizByZoneGroupBox.Visible )
            {
                var zones = new List<ZonesWithItems>();
                foreach (IZone item in _zonesList)
                {
                    var zone = new ZonesWithItems
                               {
                                   Count = 0
                               };
                    zone.SetZone(item);
                    zones.Add(zone);
                }
                zonesWithItemsBindingSource.DataSource = zones;
            }
        }

        private void SizAddInListClick(object sender, EventArgs e)
        {
            if ( iEquipmentBindingSource.Current != null )
            {
                professionEquipmentBindingSource.Add(iEquipmentBindingSource.Current);
            }
        }

        private void SizRemoveFromListClick(object sender, EventArgs e)
        {
            if ( professionEquipmentBindingSource.Current != null )
            {
                professionEquipmentBindingSource.RemoveCurrent();
            }
        }

        private void ProfessionAddButtonClick(object sender, EventArgs e)
        {
            try
            {
                iProfessionBindingSource.Add(new StandartProfession(MaxProfessionId(), professionNameTextBox.Text, new List<IEquipment>(_professionEquipmentsList), professionOrderTextBox.Text));
                professionNameTextBox.Clear();
                professionOrderTextBox.Clear();
                _professionEquipmentsList = new List<IEquipment>();
                professionEquipmentBindingSource.DataSource = _professionEquipmentsList;
            }
            catch ( Exception exception )
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private void ProfessionRemoveButtonClick(object sender, EventArgs e)
        {
            if ( iProfessionBindingSource.Current != null )
            {
                iProfessionBindingSource.RemoveCurrent();
                professionNameTextBox.Clear();
                professionOrderTextBox.Clear();
                _professionEquipmentsList = new List<IEquipment>();
                professionEquipmentBindingSource.DataSource = _professionEquipmentsList;
            }
        }

        private void ProfessionApplyButtonClick(object sender, EventArgs e)
        {
            if (_professionSelectedId<= -1)
            {
                MessageBox.Show("Выберите элемент для правки");
                return;
            }
            int index = _professionsList.IndexOf((IProfession)iEquipmentBindingSource.Current);
            _professionsList[index] = new StandartProfession(_professionSelectedId, professionNameTextBox.Text, new List<IEquipment>(_professionEquipmentsList), professionOrderTextBox.Text);
            iProfessionBindingSource[iProfessionBindingSource.Position] = _professionsList[index];
        }

        private void ProfessionDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ( iProfessionBindingSource.Current is StandartProfession )
            {
                _professionSelectedId = ((StandartProfession)iProfessionBindingSource.Current).Id;
                professionNameTextBox.Text = ((StandartProfession)iProfessionBindingSource.Current).Name;
                professionOrderTextBox.Text = ((StandartProfession)iProfessionBindingSource.Current).OrderText;
                _professionEquipmentsList = new List<IEquipment>(((StandartProfession)iProfessionBindingSource.Current).Equipments);
                professionEquipmentBindingSource.DataSource = _professionEquipmentsList;
            }
        }
    }
}
