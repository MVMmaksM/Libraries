using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DBWorkLibraries.Entities
{
    internal class CuttingMapDetail
    {  
        public long CuttingMapId { get; set; }
        public CuttingMap? CuttingMap { get; set; }
        public List<Detail> Details { get; set; }     
    }
}
