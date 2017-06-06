﻿namespace Model.Equipments
{
    /// <summary>
    /// СИЗы
    /// </summary>
    public interface IEquipment
    {
        int Id { get; set; }
        string Name { get; set; }

        string CountString { get; }

        /// <summary>
        /// Срок использования
        /// </summary>
        string TermOfUse { get; }

        /// <summary>
        /// Единицы измерения.
        /// </summary>
        string Units { get; set; }
    }
}
