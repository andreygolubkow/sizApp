using System;

namespace Model.Zones
{
    [Serializable]
    public class StandartZone:IZone
    {
        private int _id;
        private int _num;
        private string _asString;

        public StandartZone(int id, int num, string asString)
        {
            Id = id;
            Num = num;
            AsString = asString;
        }

        #region Implementation of IZone

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
                    throw new ArgumentOutOfRangeException("Не верный ID");
                }
                _id = value;
            }
        }

        public int Num
        {
            get
            {
                return _num;
            }
            set
            {
                if ( value < 0 )
                {
                    throw new ArgumentOutOfRangeException("Номер не может быть отрицательным");
                }
                _num = value;
            }
        }

        public string AsString
        {
            get
            {
                return _asString;
            }
            set
            {
                if ( value.Length == 0 )
                {
                    throw new ArgumentException("Представление в виде строки не может быть пустым");
                }
                _asString = value;
            }
        }

        #endregion
    }
}