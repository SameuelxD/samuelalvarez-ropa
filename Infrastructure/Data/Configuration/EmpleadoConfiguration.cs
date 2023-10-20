using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.ToTable("Empleado");

            builder.HasIndex(x => x.Id);
            builder.Property(x => x.Id);

            builder.Property(x => x.IdEmp)
            .IsRequired()
            .HasColumnType("int");

            builder.HasIndex(x => x.IdEmp)
            .IsUnique();

            builder.Property(x => x.Nombre)
            .IsRequired()
            .HasMaxLength(20);

            builder.Property(x => x.FechaIngreso)
            .IsRequired()
            .HasColumnType("DateTime");

            builder.HasOne(x => x.Cargos)
            .WithMany(x => x.Empleados)
            .HasForeignKey(x => x.IdCargo);

            builder.HasOne(x => x.Municipios)
            .WithMany(x => x.Empleados)
            .HasForeignKey(x => x.IdMunicipio);  
        }
    }
}