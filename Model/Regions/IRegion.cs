namespace Model.Regions
{
    /// <summary>
    /// Регионы с привязкой к поясам
    /// </summary>
    public interface IRegion
    {
        
        int Id { get; set; }

        string Name { set; get; }

        IZone Zone { get; set; }
    }
}