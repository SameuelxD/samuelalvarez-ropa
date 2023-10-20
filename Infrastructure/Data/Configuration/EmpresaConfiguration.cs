using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("Empresa");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.Property(x => x.Nit)
            .IsRequired()
            .HasMaxLength(20);

            builder.Property(x => x.RazonSocial)
            .IsRequired()
            .HasMaxLength(20);

            builder.Property(x => x.RepresentanteLegal)
            .IsRequired()
            .HasMaxLength(20);

            builder.Property(x => x.FechaCreacion)
            .IsRequired()
            .HasColumnType("DateTime");

            builder.HasOne(x => x.Municipios)
            .WithMany(x => x.Empresas)
            .HasForeignKey(x => x.IdMun);

        }
    }
}