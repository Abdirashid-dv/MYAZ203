namespace Entities.Models;

public class Categories
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<Items>? Items { get; set; }

    public Categories()
    {
    }
}