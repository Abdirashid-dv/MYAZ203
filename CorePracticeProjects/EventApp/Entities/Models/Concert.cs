
namespace Entities.Models;

public class Concert : Event
{
    public List<string>? BandLineup { get; set; }
    public string? Genre { get; set; } // ? means nullable

}