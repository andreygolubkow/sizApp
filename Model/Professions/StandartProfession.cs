using System;
using System.Collections.Generic;

using Model.Equipments;

namespace Model.Professions
{
    public class StandartProfession : IProfession
    {
        private int _id;
        private string _name;

        public StandartProfession(int id, string name, IEnumerable<IEquipment> equipments, string orderText)
        {
            Id = id;
            Name = name;
            Equipments = equipments;
            OrderText = orderText;
        }

        public StandartProfession()
        {
        }

        #region Implementation of IProfession

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
                    throw new ArgumentOutOfRangeException("Ошибка ввода id.");
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
                    throw new ArgumentException("Имя не может быть пустое.");
                }
                _name = value;
            }
        }

        public IEnumerable<IEquipment> Equipments { get; set; }

        public string OrderText { get; set; }

        #endregion
    }
}