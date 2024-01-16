namespace Entities.Models;

public class Attendee
{
    public int AttendeeID { get; set; }
    public string? Name { get; set; } // ? means nullable
    public string? ContactInfo { get; set; }
    public List<Booking> BookingHistory { get; set; }

}
