using System;
using System.Collections.Generic;
using System.Globalization;

using Model.Zones;

namespace Model.Equipments
{
    [Serializable]
    public class ByZoneEquipment:IEquipment
    {
        private int _id;
        private string _name;
        private IDictionary<IZone, double> _countByZone;

        public ByZoneEquipment(int id,string name, IDictionary<IZone,double> countDictionary , string units)
        {
            Id = id;
            Name = name;
            CountByZone = countDictionary;
            Units = units;
        }

        #region Implementation of IEquipment

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if ( value < 0 )
                {
                    throw new ArgumentOutOfRangeException("Ошибка при вводе ID");
                }
                _id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if ( value.Length == 0 )
                {
                    throw new ArgumentException("Название не может быть пустым");
                }
                _name = value;
            }
        }

        public string CountString
        {
            get
            {
                var countString="";
                foreach (KeyValuePair<IZone, double> row in CountByZone)
                {
                    countString += row.Key.AsString + "-" + Convert.ToString(row.Value, CultureInfo.InvariantCulture) + "\n";
                }
                return countString;
            }
        }

        public string TermOfUse => "";

        #endregion

        public IDictionary<IZone, double> CountByZone
        {
            get
            {
                return _countByZone;
            }
            set
            {
                if ( value.Count == 0 )
                {
                    throw new ArgumentException("Пустой список СИЗ по поясам");
                }
                _countByZone = value;
            }
        }

       public string Units { get; set; }

    }
}