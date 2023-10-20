using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class OrdenConfiguration : IEntityTypeConfiguration<Orden>
    {
        public void Configure(EntityTypeBuilder<Orden> builder)
        {
            builder.ToTable("Orden");

            builder.HasIndex(x => x.IdOrden);
            builder.Property(x => x.IdOrden);

            builder.Property(x => x.Fecha)
            .IsRequired()
            .HasColumnType("DateTime");

            builder.HasOne(x => x.Empleados)
            .WithMany(x => x.Ordenes)
            .HasForeignKey(x => x.IdEmpleado);

            
            builder.HasOne(x => x.Clientes)
            .WithMany(x => x.Ordenes)
            .HasForeignKey(x => x.IdCliente);

            
            builder.HasOne(x => x.Estados)
            .WithMany(x => x.Ordenes)
            .HasForeignKey(x => x.IdEstado);


        }
    }
}