using Entities.Models;
using Repositories.Contracts;

namespace Repositories;

public class BookingRepository : IBookable
{
    private EventManagementContext _context;

    public BookingRepository(EventManagementContext context)
    {
        _context = context;
    }
    public void CancelBooking(Booking booking)
    {
        _context.Bookings.Remove(booking);
    }

    public bool CheckAvailability(DateTime date)
    {
        if (_context.Events.Any(e => e.EventDate > date))
        {
            return true;
        }
        return false;
    }

    public Booking MakeBooking(Attendee attendee, DateTime date, string ticketType, int numberOfTickets)
    {
        var attendeeInDb = _context.Attendees.FirstOrDefault(a => a.AttendeeID == attendee.AttendeeID);

        // Check if there's an event on the given date
        var eventOnDate = _context.Events.FirstOrDefault(e => e.EventDate == date);
        if (eventOnDate == null)
        {
            throw new ArgumentException("No event on the given date.");
        }

        // Check if the attendee has already booked for the event
        var booking = _context.Bookings.FirstOrDefault(b => b.EventID == eventOnDate.EventID && b.AttendeeID == attendee.AttendeeID);
        if (booking != null)
        {
            throw new ArgumentException("Attendee has already booked for the event.");
        }

        // Create a new booking
        booking = new Booking
        {
            EventID = eventOnDate.EventID,
            Event = eventOnDate,
            AttendeeID = attendee.AttendeeID,
            Attendee = attendee,
            TicketType = ticketType,
            NumberOfTickets = numberOfTickets,
            TotalCost = CalculateCost(ticketType, numberOfTickets)
        };

        // Add the booking to the database
        _context.Bookings.Add(booking);
        attendeeInDb?.BookingHistory.Add(booking);

        // Save changes
        _context.SaveChanges();
        return booking;

    }

    private int CalculateCost(string ticketType, int numberOfTickets)
    {
        int cost = 0;
        cost = ticketType switch
        {
            "Standard" => 10,
            "VIP" => 20,
            "VVIP" => 30,
            _ => throw new ArgumentException("Invalid ticket type."),
        };
        return cost * numberOfTickets;
    }
}