using DBWorkLibraries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBWorkTest.Entities.Configuring
{
    internal class MaterialConfig : IEntityTypeConfiguration<Material>
    {
        public void Configure(EntityTypeBuilder<Material> entity)
        {
            entity.HasKey(m => m.Id).HasName("PK_Material");
            entity.Property(p=>p.Title).HasMaxLength(100).IsRequired(true);
            entity.Property(p=>p.FullName).HasMaxLength(100).IsRequired(true);
            entity.Property(p=>p.Thick).IsRequired(true);
            entity.HasOne(m=>m.CuttingMap)
                .WithOne(c=>c.Material) //один к олному
                .HasForeignKey<CuttingMap>(c=>c.MaterialId); // внешний ключ для CuttingMap            
        }
    }
}
