using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("person");

            builder.Property(p=> p.Id);

            builder.Property(p => p.NamePerson)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(p => p.Birthday)
            .HasColumnType("date");

            builder.Property(p=> p.Birthday);
            
          
        }
    }
}