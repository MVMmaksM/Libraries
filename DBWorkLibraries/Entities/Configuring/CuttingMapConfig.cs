using DBWorkLibraries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBWorkTest.Entities.Configuring
{
    internal class CuttingMapConfig : IEntityTypeConfiguration<CuttingMap>
    {
        public void Configure(EntityTypeBuilder<CuttingMap> entity)
        {
            entity.HasKey(k => k.Id).HasName("PK__CuttingMap");

            entity.ToTable("CuttingMap");

            entity.Property(p => p.FullName).HasMaxLength(100).IsConcurrencyToken();
            entity.Property(p => p.Title).HasMaxLength(100).IsConcurrencyToken();
            entity.Property(p => p.MaterialId).IsConcurrencyToken();
            entity.Property(p => p.SheetId).IsConcurrencyToken();

            entity.HasOne(c => c.Material).WithMany(m => m.CuttingMaps)
                .HasForeignKey(c => c.MaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CuttingMapMaterial");

            entity.HasOne(c => c.Sheet).WithMany(s => s.CuttingMaps)
                .HasForeignKey(c => c.SheetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CuttingMapSheet");
        }
    }
}
