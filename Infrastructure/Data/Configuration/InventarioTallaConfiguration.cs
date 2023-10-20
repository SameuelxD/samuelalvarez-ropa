using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InventarioTallaConfiguration : IEntityTypeConfiguration<InventarioTalla>
    {
        public void Configure(EntityTypeBuilder<InventarioTalla> builder)
        {
            builder.ToTable("InventarioTalla");

            builder.HasIndex(x => new { x.IdInv , x.IdTalla});

            builder.Property(x => x.Cantidad)
            .IsRequired()
            .HasColumnType("int");

            builder.HasOne(x => x.Inventarios)
            .WithMany(x => x.InventarioTallas)
            .HasForeignKey(x => x.IdInv);

            builder.HasOne(x => x.Tallas)
            .WithMany(x => x.InventarioTallas)
            .HasForeignKey(x => x.IdTalla);
        }
    }
}