using System;
using System.Globalization;

namespace Model.Equipments
{
    public class StringCountEquipment:IEquipment
    {
        private int _id;
        private string _name;
        private string _count;

        public StringCountEquipment(int id,string name, string count)
        {
            Id = id;
            Name = name;
            Count = count;
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
                    throw new ArgumentException("Неверное название");
                }
                _name = value;
            }
        }

        public string CountString => Count;
        public string TermOfUse => "";
        #endregion

        public string Count
        {
            get
            {
                return _count;
            }
            set
            {
                if ( value.Length == 0 )
                {
                    throw new ArgumentException("Ошибка в количестве");
                }
                _count = value;
            }
        }
    }
}