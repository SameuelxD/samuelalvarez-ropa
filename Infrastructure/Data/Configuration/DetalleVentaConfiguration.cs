using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class DetalleVentaConfiguration : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            builder.ToTable("DetalleVenta");

            builder.HasIndex(x => x.Id);
            builder.Property(x => x.Id);

            builder.Property(x => x.Cantidad)
            .IsRequired()
            .HasColumnType("int");

            builder.Property(x => x.ValorUnit)
            .IsRequired()
            .HasColumnType("double");

            builder.HasOne(x => x.Ventas)
            .WithMany(x => x.DetallesVenta)
            .HasForeignKey(x => x.IdVenta);

            builder.HasOne(x => x.Inventarios)
            .WithMany(x => x.DetallesVenta)
            .HasForeignKey(x => x.IdProducto);

            builder.HasOne(x => x.Tallas)
            .WithMany(x => x.DetallesVenta)
            .HasForeignKey(x => x.IdTalla);
        }
    }
}