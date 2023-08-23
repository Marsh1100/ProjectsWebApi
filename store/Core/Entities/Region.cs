

namespace Core.Entities;

public class Region
{
    public int Id { get; set; }
    public string NameRegion { get; set;}
    public int IdStateFK  { get; set; }
    public State State { get; set; }

}
