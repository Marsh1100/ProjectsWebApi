using System.Runtime.Serialization;

namespace Core.Entities;

public class Country : BaseEntity
{
    public string NameCountry { get; set; }

    public ICollection<State> States { get; set; }

}