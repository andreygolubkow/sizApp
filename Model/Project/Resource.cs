namespace Model.Project
{
    using System;

    using Model.Employee;
    using Model.Equipments;

    /// <summary>
    /// Вещь которая выдается.
    /// </summary>
    public class Resource
    {
        private double _count;

        public IEquipment Equipment { get; set; }

        public double Count
        {
            get
            {
                return _count;
            }
            set
            {
                if ( value > 0 )
                {
                    _count = value;
                }
                else
                {
                    throw new ArgumentException("Количество должно быть больше нуля.");
                }
            }
        }

        public string Additional { get; set; }
    }
}