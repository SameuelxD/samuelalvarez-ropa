using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
    {
        public void Configure(EntityTypeBuilder<Inventario> builder)
        {
            builder.ToTable("Inventario");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.Property(x => x.CodInv)
            .IsRequired()
            .HasColumnType("int");

            builder.HasIndex(x => x.CodInv)
            .IsUnique();

            builder.Property(x => x.ValorVtaCop)
            .IsRequired()
            .HasColumnType("double");

            builder.Property(x => x.ValorVtaUsd)
            .IsRequired()
            .HasColumnType("double");
            
            builder.HasOne(x => x.Prendas)
            .WithMany(x => x.Inventarios)
            .HasForeignKey(x => x.IdPrenda);
        }
    }
}