using DBWorkLibraries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBWorkTest.Entities.Configuring
{
    internal class CuttingMapDetailConfig : IEntityTypeConfiguration<CuttingMapDetail>
    {
        public void Configure(EntityTypeBuilder<CuttingMapDetail> entity)
        {
            entity.HasKey(c => new { c.CuttingMapId, c.Details });
        }
    }
}
