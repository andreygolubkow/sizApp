using System;
using System.CodeDom;
using System.Collections.Generic;

namespace Model.Equipments
{
    public class CompositeEquipment:IEquipment
    {
        private int _id;
        private string _name;
        private List<IEquipment> _equipmentsList;

        public CompositeEquipment(int id)
        {
            _equipmentsList = new List<IEquipment>();
            Id = id;
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
                    throw new ArgumentException("Ошибка в наименовании");
                }
                _name = value;
            }
        }

        public string CountString => "...";

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

        public void RemoveEquipment(int index)
        {
            if ( index < 0 )
            {
                throw new ArgumentOutOfRangeException("Неверный индекс для удаления");
            }
            if ( index > _equipmentsList.Count-1 )
            {
                throw new ArgumentOutOfRangeException("Нет такого элемента");
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