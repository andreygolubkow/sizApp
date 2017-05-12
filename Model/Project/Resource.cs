namespace Model.Project
{
    using System;

    using Model.Employee;
    using Model.Equipments;

    /// <summary>
    /// Вещь которая выдается.
    /// </summary>
    [Serializable]
    public class Resource
    {
        private string _count;

        public IEquipment Equipment { get; set; }

        public string Count
        {
            get => _count;
            set => _count = value;
        }

        /// <summary>
        /// Дата выдачи.
        /// </summary>
        public DateTime IssueDate { get; set; }

        public string Additional { get; set; }
    }
}