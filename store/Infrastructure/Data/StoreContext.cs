using System.Reflection;
using Core.Entities; 
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.data;

public class StoreContext : DbContext
{
    public StoreContext(DbContextOptions<StoreContext> options) : base(options)
    {
    }

    public DbSet<Country> Countries { get; set; }
    public DbSet<State> States { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<Person> Persons { get; set; }

    public DbSet<PersonType> PersonTypes { get; set; }
    public DbSet<Product> Products { get; set; }

    public DbSet<ProductPerson> ProductPersons { get; set; }


    //Sobrecarga qur toma los modelos que se han definido en configuración
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
