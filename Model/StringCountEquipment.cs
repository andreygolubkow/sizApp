using System;

namespace Model
{
    public class StringCountEquipment:IEquipment
    {
        private int _id;
        private string _name;
        private string _count;

        #region Implementation of IEquipment

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if ( value <= 0 )
                {
                    throw new ArgumentOutOfRangeException("Не верный ID");
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
                    throw new ArgumentException("Не верное название");
                }
                _name = value;
            }
        }

        public string CountString => Count;
        #endregion

        private string Count
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