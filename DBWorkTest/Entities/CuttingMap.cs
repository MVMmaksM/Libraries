using System.ComponentModel.DataAnnotations;

namespace DBWorkLibraries.Entities
{
    internal class CuttingMap
    {
        public long Id { get; }
        public string Title { get; set; }
        public string FullName { get; set; }
        public long MaterialId { get; set; } // внешний ключ
        public Material Material { get; set; } // навигационное св-во
        public long SheetId { get; set; } // внешний ключ
        public Sheet Sheet { get; set; } // навигационное св-во
        public long CuttingMapDetailId { get; set; }
        public CuttingMapDetail CuttingMapDetail { get; set; }        
    }
}
