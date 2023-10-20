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
    public class InsumoPrendaConfigurartion : IEntityTypeConfiguration<InsumoPrenda>
    {
        public void Configure(EntityTypeBuilder<InsumoPrenda> builder)
        {
            builder.ToTable("InsumoPrenda");

            builder.HasKey(x => new { x.IdInsumo,x.IdPrenda});
            
            builder.Property(x => x.Cantidad)
            .IsRequired()
            .HasColumnType("int");

            builder.HasOne(x => x.Insumos)
            .WithMany(x => x.InsumosPrenda)
            .HasForeignKey(x => x.IdInsumo);

            builder.HasOne(x => x.Prendas)
            .WithMany(x => x.InsumosPrenda)
            .HasForeignKey(x => x.IdPrenda);


        }
    }
}