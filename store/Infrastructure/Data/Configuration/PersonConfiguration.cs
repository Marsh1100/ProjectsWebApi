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

            builder.Property(p => p.IdPerson)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(p => p.NamePerson)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(p => p.Birthday)
            .HasColumnType("date");

            builder.HasOne(p=>p.PersonType)
            .WithMany(p=>p.Persons)
            .HasForeignKey(p => p.IdPersonTypeFK );          
          
            builder
            .HasMany(p => p.Products)
            .WithMany(p => p.Persons)
            .UsingEntity<ProductPerson>(
                j => j
                    .HasOne(pt => pt.Product)
                    .WithMany(t => t.ProductPersons)
                    .HasForeignKey(pt => pt.IdProductFK),
                 j => j
                    .HasOne(pt => pt.Person)
                    .WithMany(t => t.ProductPersons)
                    .HasForeignKey(pt => pt.IdPersonFK),
                    j=>
                    {
                        //Llave compuesta
                        j.HasKey(t => new {t.IdPersonFK, t.IdProductFK});
                    }
                
            );
        }
    }
}