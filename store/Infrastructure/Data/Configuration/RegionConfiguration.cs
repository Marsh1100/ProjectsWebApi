using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class RegionConfiguration : IEntityTypeConfiguration<Region>
{
    public void Configure(EntityTypeBuilder<Region> builder)
    {
        // Aquí puedes configurar las propiedades de la entidad Marca
        // utilizando el objeto 'builder'.
        builder.ToTable("region");

        builder.Property(p => p.NameRegion)
        .IsRequired()
        .HasMaxLength(50);
        
        builder.HasOne(p => p.State)
        .WithMany(p=> p.Regions)
        .HasForeignKey(p=>p.IdStateFK);
    }
}
