using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

using Model.Professions;

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

        public CorrectEquipmentAdapter(IEquipment equipment, IZone zone, IProfession profession)
        {
            _equipment = equipment;
            _zone = zone;
            Profession = profession;
        }

        public bool Correct => !(_equipment is CompositeEquipment);

        public string CorrectString => Correct ? "Готово" : "Требует настройки";

        public IProfession Profession { get; set; }

        public DateTime IssueDateTime { get; set; }

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
                    return Convert.ToString(count, CultureInfo.InvariantCulture);
                }

                    return _equipment.CountString;
            }
        }

        public IEquipment GetEquipment()
        {
            return _equipment;
        }
        /// <summary>
        /// Примечания для СИЗ
        /// </summary>
        public string Notes { get; set; }

        public static List<CorrectEquipmentAdapter> AdaptEquipmentList(List<IEquipment> equipments, IZone zone)
        {
            var correctList = new List<CorrectEquipmentAdapter>();
            foreach (IEquipment equipment in equipments)
            {
                correctList.Add(new CorrectEquipmentAdapter(equipment, zone, null));
            }
            return correctList;
        }

    }
}
