using System;
using System.Globalization;

namespace Model.Equipments
{
    public class PerYearEquipment:IEquipment
    {
        private string _name;
        private double _countPerYear;
        private int _id;

        public  PerYearEquipment(int id,string name, double count)
        {
            Id = id;
            Name = name;
            CountPerYear = count;
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

        public string TermOfUse => Convert.ToString(12/CountPerYear, CultureInfo.InvariantCulture);

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