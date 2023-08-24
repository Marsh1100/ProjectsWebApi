namespace Core.Entities;

public class PersonType : BaseEntity
{
    public string Description { get; set; }

    public ICollection<Person> Persons { get; set; }
}
