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
    public class PrendaConfiguration : IEntityTypeConfiguration<Prenda>
    {
        public void Configure(EntityTypeBuilder<Prenda> builder)
        {
            builder.ToTable("Prenda");
            
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.Property(x => x.IdPrenda)
            .IsRequired();

            builder.HasIndex(x => x.IdPrenda)
            .IsUnique();

            builder.HasOne(x => x.Estados)
            .WithMany(x => x.Prendas)
            .HasForeignKey(x => x.IdEstado);

            builder.HasOne(x => x.TiposProteccion)
            .WithMany(x => x.Prendas)
            .HasForeignKey(x => x.IdTipoProteccion);

            builder.HasOne(x => x.Generos)
            .WithMany(x => x.Prendas)
            .HasForeignKey(x => x.IdGenero);
            
        }
    }
}