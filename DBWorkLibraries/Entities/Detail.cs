using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DBWorkLibraries.Entities;

public class Detail
{
    public long Id { get; }
    public string Title { get; set; } = null!;
    public string FullName { get; set; } = null!;
    public byte[] Contours { get; set; } = null!;
    public ICollection<CuttingMapDetail> CuttingMapDetails { get; } = new List<CuttingMapDetail>();
}
