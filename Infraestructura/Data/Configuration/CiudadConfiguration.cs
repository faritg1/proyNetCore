using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.Data.Configuration;
    public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
    {
        public void Configure(EntityTypeBuilder<Ciudad> builder){
            builder.ToTable("ciudad");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(50);

            builder.HasOne(e => e.Departamentos).WithMany(e => e.Ciudades).HasForeignKey(e => e.IddepartamentoFk);
        }
    }
