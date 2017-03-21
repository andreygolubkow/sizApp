namespace Model.Zones
{
    /// <summary>
    /// Пояса
    /// </summary>
    public interface IZone
    {   
        int Id { get; set; }

        int Num { get; set; }

        string AsString { get; set; }

    }
}