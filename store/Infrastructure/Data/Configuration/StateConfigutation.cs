using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class StateConfiguration : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("state");

            builder.Property(p => p.NameState)
            .IsRequired()
            .HasMaxLength(50);
            
            builder.HasOne(p => p.Country)
            .WithMany(p=> p.States)
            .HasForeignKey(p=>p.IdCountryFK);

            
        }
    }
}

