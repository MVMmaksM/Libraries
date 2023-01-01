using DBWorkLibraries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBWorkTest.Entities.Configuring
{
    internal class DetailConfig : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> entity)
        {
            entity.ToTable(nameof(Detail)); // имя таблицы в БД

            entity.HasKey(d => d.Id).HasName("PK_Detail");
            entity.Property(p => p.Title).HasMaxLength(100).IsRequired(true);
            entity.Property(p => p.FullName).HasMaxLength(100).IsRequired(true);
            entity.Property(p => p.Contours).IsRequired(true);

            entity.HasOne(d => d.CuttingMapDetail)
                .WithMany(cmd => cmd.Details)
                .HasForeignKey(d => new {d.CuttingMapDetailId, d.CuttingMapId });
        }
    }
}
