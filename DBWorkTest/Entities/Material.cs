namespace DBWorkLibraries.Entities;
public class Material
{
    public long Id { get;}
    public string Title { get; set; } = null!;
    public string FullName { get; set; } = null!;
    public float Thick { get; set; }
    public ICollection<CuttingMap> CuttingMaps { get; } = new List<CuttingMap>();
}
