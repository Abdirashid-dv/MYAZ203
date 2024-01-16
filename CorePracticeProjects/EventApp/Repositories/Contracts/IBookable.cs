using Entities.Models;

namespace Repositories.Contracts;

public interface IBookable
{
    bool CheckAvailability(DateTime date);
    Booking MakeBooking(Attendee attendee, DateTime date, string ticketType, int numberOfTickets);
    void CancelBooking(Booking booking);
}