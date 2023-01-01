using DBWorkLibraries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBWorkTest.Entities.Configuring
{
    internal class DetailConfig : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> entity)
        {
            entity.Property(p => p.Title).HasMaxLength(100).IsRequired(true);
            entity.Property(p => p.FullName).HasMaxLength(100).IsRequired(true);
            entity.Property(p => p.Contours).IsRequired(true);
        }
    }
}
