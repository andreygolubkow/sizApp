using System;
using System.Collections.Generic;

namespace Tools
{
    using Model.Equipments;
    using Model.Zones;

    public class CorrectEquipmentAdapter
    {
        private IEquipment _equipment;

        private IZone _zone;

        public CorrectEquipmentAdapter()
        {
            _equipment = new StringCountEquipment(0,string.Empty,"",string.Empty);
        }

        public CorrectEquipmentAdapter(IEquipment equipment, IZone zone)
        {
            _equipment = equipment;
        }

        public bool Correct => !(_equipment is CompositeEquipment);

        public string Name => _equipment.Name;

        public string Count
        {
            get
            {
                if ( _equipment is ByZoneEquipment )
                {
                    double count = 0;
                    foreach (KeyValuePair<IZone, double> kp in ((ByZoneEquipment)_equipment).CountByZone)
                    {
                        if ( kp.Key.Id == _zone.Id )
                        {
                            count = kp.Value;
                        }
                    }
                    return Convert.ToString(count);
                }

                    return _equipment.CountString;
            }
        }

        public static List<CorrectEquipmentAdapter> AdaptEquipmentList(List<IEquipment> equipments, IZone zone)
        {
            var correctList = new List<CorrectEquipmentAdapter>();
            foreach (IEquipment equipment in equipments)
            {
                correctList.Add(new CorrectEquipmentAdapter(equipment,zone));
            }
            return correctList;
        }

    }
}
