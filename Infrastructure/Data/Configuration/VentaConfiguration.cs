using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class VentaConfiguration : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.ToTable("Venta");
            builder.HasIndex(x => x.Id);

            builder.Property(x => x.Fecha)
            .IsRequired()
            .HasColumnType("DateTime");

            builder.HasOne(x => x.Empleados)
            .WithMany(x => x.Ventas)
            .HasForeignKey(x => x.IdEmpleado);

            
            builder.HasOne(x => x.Clientes)
            .WithMany(x => x.Ventas)
            .HasForeignKey(x => x.IdCliente);

            
            builder.HasOne(x => x.FormasPago)
            .WithMany(x => x.Ventas)
            .HasForeignKey(x => x.IdFormaPago);
        }
    }
}