namespace Entities.Models;

public class Order
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public List<Items>? Orders { get; set; }
    public DateTime OrderDate { get; set; }

}