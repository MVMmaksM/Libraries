
namespace DBWorkLibraries.Entities
{
    internal class Detail
    {
        public long Id { get; }        
        public string Title { get; set; }       
        public string FullName { get; set; }
        public byte[] Contours { get; set; }
        public long CuttingMapDetailId { get; set; }
        public CuttingMapDetail CuttingMapDetail { get; set; }

        public long CuttingMapId { get; set; }
    }
}
