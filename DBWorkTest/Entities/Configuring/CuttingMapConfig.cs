﻿using DBWorkLibraries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBWorkTest.Entities.Configuring
{
    internal class CuttingMapConfig : IEntityTypeConfiguration<CuttingMap>
    {
        public void Configure(EntityTypeBuilder<CuttingMap> entity)
        {
            entity.ToTable(nameof(CuttingMap));

            entity.HasKey(c => c.Id).HasName("PK_CuttingMap");
            entity.Property(p => p.Title).HasMaxLength(100).IsRequired(true);
            entity.Property(p => p.FullName).HasMaxLength(100).IsRequired(true);

            entity.HasOne(cm => cm.CuttingMapDetail)
                .WithOne(cmd => cmd.CuttingMap)
                .HasForeignKey<CuttingMapDetail>(cmd=>cmd.CuttingMapId);
        }
    }
}
