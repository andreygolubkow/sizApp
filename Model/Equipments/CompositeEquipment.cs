using System;
using System.Collections.Generic;

namespace Model.Equipments
{
    [Serializable]
    public class CompositeEquipment:IEquipment
    {
        private int _id;
        private string _name;
        private List<IEquipment> _equipmentsList;

        public CompositeEquipment(int id,string name,List<IEquipment> equipments , string units)
        {
            _equipmentsList = equipments;
            Id = id;
            Name = name;
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
                    throw new ArgumentOutOfRangeException($"Ошибка при вводе ID");
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
                    throw new ArgumentException("Ошибка в наименовании");
                }
                _name = value;
            }
        }

        public string CountString => "...";

        public string TermOfUse => "";

        #endregion

        public void AddEquipment(IEquipment equipment)
        {
            if ( equipment != null )
            {
                _equipmentsList.Add(equipment);
            }
            else
            {
                throw new ArgumentException("Пустое СИЗ");
            }
        }

        public string Units { get; set; }


        public void RemoveEquipment(int index)
        {
            if ( index < 0 )
            {
                throw new ArgumentOutOfRangeException("index");
            }
            if ( index > _equipmentsList.Count-1 )
            {
                throw new ArgumentOutOfRangeException("index");
            }
        }

        public List<IEquipment> EquipmentsList
        {
            get
            {
                return _equipmentsList;
            }
            set
            {
                if ( value == null )
                {
                    throw new ArgumentException("Список пустой");
                }
                _equipmentsList = value;
            }
        }
    }
}