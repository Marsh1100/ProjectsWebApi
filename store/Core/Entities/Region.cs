

namespace Core.Entities;

public class Region : BaseEntity
{
    public string NameRegion { get; set;}
    public int IdStateFK  { get; set; }
    public State State { get; set; }

}
