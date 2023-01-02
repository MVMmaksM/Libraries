using DBWorkLibraries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBWorkTest.Entities.Configuring
{
    internal class CuttingMapDetailConfig : IEntityTypeConfiguration<CuttingMapDetail>
    {
        public void Configure(EntityTypeBuilder<CuttingMapDetail> entity)
        {
            entity.HasKey(k => k.Id).HasName("PK__CuttingMapDetail");

            entity.ToTable("CuttingMapDetail");

            entity.HasIndex(i => new { i.CuttingMapId, i.DetailId }, "UQ__CutMapIdDetId).IsUnique()");

            entity.Property(p => p.Id).HasColumnName("id");

            entity.HasOne(cmd => cmd.CuttingMap).WithMany(cm => cm.CuttingMapDetails)
                .HasForeignKey(cmd => cmd.CuttingMapId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CuttingMapId");

            entity.HasOne(cmd => cmd.Detail).WithMany(d => d.CuttingMapDetails)
                .HasForeignKey(cmd => cmd.DetailId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CuttingDetailId");
        }
    }
}
