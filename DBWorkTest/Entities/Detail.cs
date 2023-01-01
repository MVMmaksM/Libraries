
namespace DBWorkLibraries.Entities
{
    internal class Detail
    {
        public long Id { get; set; }        
        public string Title { get; set; }       
        public string FullName { get; set; }
        public byte[] Contours { get; set; }
    }
}
