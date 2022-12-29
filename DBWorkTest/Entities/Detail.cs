using System.ComponentModel.DataAnnotations;

namespace DBWorkLibraries.Entities
{
    internal class Detail
    {
        public long Id { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(100)]
        public string FullName { get; set; }

        public byte[] Contours { get; set; }
    }
}
