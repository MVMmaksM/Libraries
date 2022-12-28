using System.ComponentModel.DataAnnotations;

namespace DBWorkLibraries.Model
{
    internal class Sheet
    {
        public long Id { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(100)]
        public string FullName { get; set; }

        public float Width { get; set; }

        public float Height { get; set; }
    }
}
