namespace Core.Entities;

public class Person
{
    public int Id { get; set;}
    public string IdPerson { get; set;}
    public string NamePerson  { get; set;}
    public DateTime Birthday { get; set;}
    public int IdPersonTypeFK { get; set;}
    public PersonType PersonType { get; set;}

    public ICollection<ProductPerson> ProductPersons { get; set;}
    public ICollection<Product> Products { get; set;} = new HashSet<Product>();

}