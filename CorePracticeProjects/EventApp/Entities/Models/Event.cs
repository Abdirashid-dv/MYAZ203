namespace Entities.Models;

public abstract class Event
{
    public int EventID { get; set; }
    public string Title { get; set; } = null!;
    public string Venue { get; set; } = null!;
    private DateTime _eventDate;
    public DateTime EventDate
    {
        get { return _eventDate; }
        set
        {
            if (value < DateTime.Now)
            {
                throw new ArgumentException("Event date cannot be in the past");
            }
            _eventDate = value;
        }
    }

    public string EventType { get; set; } = null!;
    public int MaxCapacity { get; set; }
    public List<Booking> Bookings { get; set; }
    public List<Attendee> Attendees { get; set; }

}