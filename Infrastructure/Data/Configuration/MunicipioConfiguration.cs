using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class MunicipioConfiguration : IEntityTypeConfiguration<Municipio>
    {
        public void Configure(EntityTypeBuilder<Municipio> builder)
        {
            builder.ToTable("Municipio");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.Property(x => x.Nombre)
            .IsRequired()
            .HasMaxLength(20);
            
            builder.HasOne(x => x.Departamentos)
            .WithMany(x => x.Municipios)
            .HasForeignKey(x => x.IdDep);
        }
    }
}