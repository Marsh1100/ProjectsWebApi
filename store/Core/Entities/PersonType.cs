namespace Core.Entities;

public class PersonType
{
    public int IdTypePerson { get; set; }
    public string Description { get; set; }

    public ICollection<Person> Persons { get; set; }
}
