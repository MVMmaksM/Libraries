using System.ComponentModel.DataAnnotations;

namespace DBWorkLibraries.Entities
{
    internal class Material
    {
        public long Id { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }        
        [MaxLength(100)]
        public string FullName { get; set; }
        public float Thick { get; set; }
    }
}
