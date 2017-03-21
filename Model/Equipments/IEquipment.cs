namespace Model
{
    /// <summary>
    /// СИЗы
    /// </summary>
    interface IEquipment
    {
        int Id { get; set; }
        string Name { get; set; }

        string CountString { get; }
    }
}
