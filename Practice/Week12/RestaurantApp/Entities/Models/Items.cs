namespace Entities.Models;

public class Items
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }

    public int CategoryId { get; set; }
    public Categories? Category { get; set; }
}