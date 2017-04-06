using System.Collections.Generic;

using Model.Equipments;

namespace Model.Professions
{
    public interface IProfession
    {
        int Id { get; set; }

        string Name { get; set; }

        IEnumerable<IEquipment> Equipments { get; set; }

        string OrderText { get; set; }
    }
}