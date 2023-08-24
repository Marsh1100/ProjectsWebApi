
namespace Core.Entities;

public class ProductPerson 
{
    public int IdProductFK { get; set; }
    public Product Product { get; set; }
    public int IdPersonFK  { get; set; }
    public Person Person { get; set; }
    
}
