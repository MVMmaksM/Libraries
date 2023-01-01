using DBWorkLibraries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBWorkTest.Entities.Configuring
{
    internal class SheetConfig : IEntityTypeConfiguration<Sheet>
    {
        public void Configure(EntityTypeBuilder<Sheet> entity)
        {
            entity.HasKey(s => s.Id).HasName("PK_Sheet");
            entity.Property(p=>p.Title).HasMaxLength(100).IsRequired(true);
            entity.Property(p=>p.FullName).HasMaxLength(100).IsRequired(true);
            entity.Property(p=>p.Width).IsRequired(true);
            entity.Property(p=>p.Height).IsRequired(true);
           
            entity.HasOne(s => s.CuttingMap)
                .WithOne(c => c.Sheet) // один к одному
                .HasForeignKey<CuttingMap>(c => c.SheetId); // внешний ключ для CuttingMap
        }
    }
}
