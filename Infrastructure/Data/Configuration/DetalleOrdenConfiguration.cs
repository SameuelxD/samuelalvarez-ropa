using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class DetalleOrdenConfiguration : IEntityTypeConfiguration<DetalleOrden>
    {
        public void Configure(EntityTypeBuilder<DetalleOrden> builder)
        {
            builder.ToTable("DetalleOrden");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.Property(x => x.CantidadProducir)
            .IsRequired()
            .HasColumnType("int");

            builder.Property(x => x.CantidadProducida)
            .IsRequired()
            .HasColumnType("int");

            builder.HasOne(x => x.Ordenes)
            .WithMany(x => x.DetallesOrden)
            .HasForeignKey(x => x.IdOrden);

            builder.HasOne(x => x.Prendas)
            .WithMany(x => x.DetallesOrden)
            .HasForeignKey(x => x.IdPrenda);

            builder.HasOne(x => x.Colores)
            .WithMany(x => x.DetallesOrden)
            .HasForeignKey(x => x.IdColor);

            builder.HasOne(x => x.Estados)
            .WithMany(x => x.DetallesOrden)
            .HasForeignKey(x => x.IdEstado);
        }
    }
}