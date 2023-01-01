using DBWorkLibraries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBWorkTest.Entities.Configuring
{
    internal class SheetConfig : IEntityTypeConfiguration<Sheet>
    {
        public void Configure(EntityTypeBuilder<Sheet> entity)
        {
            entity.Property(p=>p.Title).HasMaxLength(100).IsRequired(true);
            entity.Property(p=>p.FullName).HasMaxLength(100).IsRequired(true);
            entity.Property(p=>p.Width).IsRequired(true);
            entity.Property(p=>p.Height).IsRequired(true);
        }
    }
}
