using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class PaisConfiguration : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            builder.ToTable("Pais");
        
            builder.HasIndex(x => x.Id);
            builder.Property(x => x.Id);

            builder.Property(x => x.Nombre)
            .IsRequired()
            .HasMaxLength(20);

            builder.HasIndex(x => x.Nombre)
            .IsUnique();
        }
    }
}