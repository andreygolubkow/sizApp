using System;

using Model.Zones;

namespace Model.Regions
{
    [Serializable]
    public class NonStandartRegion:IRegion
    {
        private int _id;
        private string _name;
        private IZone _zone;
        private string _addition;

        public NonStandartRegion(int id, string name, string addition, IZone zone)
        {
            Id = id;
            Addition = addition;
            Name = name;
            Zone = zone;
        }

        #region Implementation of IRegion

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
                    throw new ArgumentOutOfRangeException("Неверный ID");
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
                    throw new ArgumentException("Ошибка в имени региона");
                }
                _name = value;
            }
        }

        public IZone Zone
        {
            get
            {
                return _zone;
            }
            set
            {
                _zone = value;
            }
        }

        #endregion

        public string Addition
        {
            get
            {
                return _addition;
            }
            set
            {
                if ( value.Length == 0 )
                {
                    throw new ArgumentException("Ошибка в дополнительных данных");
                }
                _addition = value;
            }
        }
    }
}