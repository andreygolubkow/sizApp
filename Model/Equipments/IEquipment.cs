namespace Model.Equipments
{
    /// <summary>
    /// СИЗы
    /// </summary>
    public interface IEquipment
    {
        int Id { get; set; }
        string Name { get; set; }

        string CountString { get; }

        string TermOfUse { get; }
    }
}
