using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DBWorkLibraries.Entities;

public class Detail
{
    public long Id { get; }
    public string Title { get; set; } = null!;
    public string FullName { get; set; } = null!;

    private byte[] contours = null!;
    [NotMapped]
    public string Contours
    {
        get => Encoding.ASCII.GetString(contours);
        set => contours = Encoding.ASCII.GetBytes(value);
    }
    public ICollection<CuttingMapDetail> CuttingMapDetails { get; } = new List<CuttingMapDetail>();
}
