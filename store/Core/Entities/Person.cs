namespace Core.Entities;

public class Person
{
    public int Id { get; set;}
    public string IdPerson { get; set;}
    public string NamePerson  { get; set;}
    public DateTime Birthday { get; set;}
    public int IdPersonTypeFK { get; set;}

}