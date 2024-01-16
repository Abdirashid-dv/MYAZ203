namespace Entities.Models;

public class Wedding : Event
{
    public string BrideName { get; set; } = null!;
    public string GroomName { get; set; } = null!;

}