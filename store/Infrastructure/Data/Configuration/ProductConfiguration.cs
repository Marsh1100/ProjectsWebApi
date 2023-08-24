using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("product");

            builder.Property(p=> p.Id);

            builder.Property(p => p.Code)
            .IsRequired()
            .HasMaxLength(50);
        
            builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(50);
            builder.Property(p => p.MinStock)
            .HasColumnType("int")
            .IsUnicode();//?

             builder.Property(p => p.MaxStock)
            .HasColumnType("int")
            .IsUnicode();//?

             builder.Property(p => p.Stock)
            .HasColumnType("int")
            .IsUnicode();//?

            builder.Property(p => p.SaleValue)
            .HasColumnType("double");         
          
        }
    }
}