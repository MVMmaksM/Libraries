namespace DBWorkLibraries.Entities;
public partial class CuttingMapDetail
{
    public long Id { get;}
    public long CuttingMapId { get; set; }
    public long DetailId { get; set; }
    public CuttingMap CuttingMap { get; set; } = null!;
    public Detail Detail { get; set; } = null!;
}
