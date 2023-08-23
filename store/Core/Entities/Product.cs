namespace Core.Entities;

public class Product
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public int MinStock { get; set; }
    public int MaxStock { get; set; }
    public int Stock { get; set; }
    public double SaleValue  { get; set; }

    public ICollection<ProductPerson> ProductPersons { get; set;}
    public ICollection<Person> Persons { get; set;} = new HashSet<Person>();



}
