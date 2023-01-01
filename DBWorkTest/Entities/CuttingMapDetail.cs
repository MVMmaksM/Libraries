
namespace DBWorkLibraries.Entities
{
    internal class CuttingMapDetail
    {  
        public long CuttingMapId { get;}
        public CuttingMap? CuttingMap { get; set; }
        public List<Detail> Details { get; set; }     
    }
}
