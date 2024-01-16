namespace Entities.Models;

public class Booking
{
    public int BookingID { get; set; }
    public int EventID { get; set; }   // Foreign key
    public Event Event { get; set; }    // Navigation property
    public string? TicketType { get; set; }
    private int _numberOfTickets;
    public int NumberOfTickets
    {
        get { return _numberOfTickets; }
        set
        {
            // value must be positive
            if (value < 0)
            {
                throw new ArgumentException("Number of tickets must be positive.");
            }
            _numberOfTickets = value;
        }
    }

    public int TotalCost { get; set; }

    public int AttendeeID { get; set; }   // Foreign key
    public Attendee Attendee { get; set; }    // Navigation property
}