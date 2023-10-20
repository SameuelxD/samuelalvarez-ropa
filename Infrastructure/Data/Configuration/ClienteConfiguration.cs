using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.Property(x => x.IdCliente)
            .IsRequired()
            .HasColumnType("int");

            builder.HasIndex(x => x.IdCliente)
            .IsUnique();

            builder.Property(x => x.Nombre)
            .IsRequired()
            .HasMaxLength(20);

            builder.Property(x => x.FechaRegistro)
            .IsRequired()
            .HasColumnType("DateTime");
            
            builder.HasOne(x => x.TiposPersona)
            .WithMany(x => x.Clientes)
            .HasForeignKey(x => x.IdTipoPersona);
            
            builder.HasOne(x => x.Municipios)
            .WithMany(x => x.Clientes)
            .HasForeignKey(x => x.IdMunicipio);

            
        }
    }
}