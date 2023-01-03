namespace DBWorkLibraries.Entities;

public class Sheet
{
    public long Id { get;}
    public string Title { get; set; } = null!;
    public string FullName { get; set; } = null!;
    public float Width { get; set; }
    public float Height { get; set; }
    public virtual ICollection<CuttingMap> CuttingMaps { get; } = new List<CuttingMap>();
}
