namespace Entities.Models;

public class Conference : Event
{
    public List<string>? SpeakerList { get; set; }
    public string? ConferenceType { get; set; }
}