using DBWorkLibraries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBWorkTest.Entities.Configuring
{
    internal class SheetConfig : IEntityTypeConfiguration<Sheet>
    {
        public void Configure(EntityTypeBuilder<Sheet> entity)
        {
            entity.HasKey(k => k.Id).HasName("PK__Sheet");
            
            entity.ToTable("Sheet");

            entity.Property(p => p.FullName).HasMaxLength(100);
            entity.Property(p => p.Title).HasMaxLength(100);
        }
    }
}
