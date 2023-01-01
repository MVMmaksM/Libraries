using DBWorkLibraries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBWorkTest.Entities.Configuring
{
    internal class MaterialConfig : IEntityTypeConfiguration<Material>
    {
        public void Configure(EntityTypeBuilder<Material> entity)
        {
            entity.HasKey(k => k.Id).HasName("PK__Material");

            entity.ToTable("Material");

            entity.Property(p => p.FullName).HasMaxLength(100);
            entity.Property(p => p.Title).HasMaxLength(100);
        }
    }
}
