
namespace Core.Entities;

public class State
{
    public int Id { get; set; }
    public string NameState { get; set;}
    public int IdCountryFK  { get; set; }

    public Country Country { get; set; }

    public ICollection<Region> Regions { get; set; }

}
