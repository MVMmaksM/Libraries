using DBWorkLibraries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBWorkTest.Entities.Configuring
{
    internal class DetailConfig : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> entity)
        {
            entity.HasKey(k => k.Id).HasName("PK__Detail");

            entity.ToTable("Detail");

            entity.Property(p => p.FullName).HasMaxLength(100).IsConcurrencyToken();
            entity.Property(p => p.Title).HasMaxLength(100).IsConcurrencyToken();
            entity.Property(p => p.Contours).IsConcurrencyToken();           
        }
    }
}
