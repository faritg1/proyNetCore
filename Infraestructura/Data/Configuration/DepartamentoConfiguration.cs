using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.Configuration;

public class DepartamentoConfiguration
{
    public void Configure(EntityTypeBuilder<Departamento> builder)
    {
        builder.ToTable("departamento");

        builder.HasKey(d => d.Id);
        builder.Property(d => d.Id);

        builder.Property(d => d.Nombre).IsRequired().HasMaxLength(50);
        
        builder.HasOne(d => d.Paises).WithMany(d => d.Departamentos).HasForeignKey(p => p.IdpaisFk);
    }
}

