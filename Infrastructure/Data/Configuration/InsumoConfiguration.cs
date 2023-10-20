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
    public class InsumoConfiguration : IEntityTypeConfiguration<Insumo>
    {
        public void Configure(EntityTypeBuilder<Insumo> builder)
        {
            builder.ToTable("Insumo");

            builder.HasIndex(x => x.Id);
            builder.Property(x => x.Id);

            builder.Property(x => x.Nombre)
            .IsRequired()
            .HasMaxLength(20);

            builder.HasIndex(x => x.Nombre)
            .IsUnique();

            builder.Property(x => x.ValorUnit)
            .IsRequired()
            .HasColumnType("double");

            builder.Property(x => x.StockMin)
            .IsRequired()
            .HasColumnType("int");

            builder.Property(x => x.StockMax)
            .IsRequired()
            .HasColumnType("int");
        }
    }
}