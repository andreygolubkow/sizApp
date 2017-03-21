using System;
using System.Globalization;

namespace Model.Equipments
{
    public class PerYearEquipment:IEquipment
    {
        private string _name;
        private double _countPerYear;
        private int _id;

        public  PerYearEquipment(int id)
        {
            Id = id;
        }

        #region Implementation of IEquipment

        public string Name
        {
            get {            
               return _name;
            }
            set
            {
                if ( value.Length == 0 )
                {
                    throw new ArgumentException("Название слишком короткое");
                }
                _name = value;
            }
        }

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
                    throw new ArgumentOutOfRangeException("Неверный Id");
                }
                _id = value;
            }
        }



        public string CountString => Convert.ToString(CountPerYear, CultureInfo.InvariantCulture);

        #endregion

        public double CountPerYear
        {
            get
            {
                return _countPerYear;
            }
            set
            {
                if ( value <= 0 )
                {
                    throw new ArgumentOutOfRangeException("Ошибка в количестве на год");
                }
                _countPerYear = value;
            }
        }
       
    }
}