namespace DBWorkLibraries.Entities;
public class CuttingMap
{
    public long Id { get;}
    public string Title { get; set; } = null!;
    public string FullName { get; set; } = null!;
    public long MaterialId { get; set; }
    public long SheetId { get; set; }
    public ICollection<CuttingMapDetail> CuttingMapDetails { get; } = new List<CuttingMapDetail>();
    public Material Material { get; set; } = null!;
    public Sheet Sheet { get; set; } = null!;
}
