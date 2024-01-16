using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories;

public class EventManagementContext : DbContext
{

    public EventManagementContext(DbContextOptions<EventManagementContext> options) : base(options)
    {
    }

    // DbSet properties for your entities
    public DbSet<Event> Events { get; set; }
    public DbSet<Conference> Conferences { get; set; }
    public DbSet<Wedding> Weddings { get; set; }
    public DbSet<Concert> Concerts { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Attendee> Attendees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configuring the relationships
        // Event and Booking (One-to-Many)

        modelBuilder.Entity<Event>()
            .HasMany(e => e.Bookings)
            .WithOne(b => b.Event)
            .HasForeignKey(b => b.EventID);

        // Attendee and Booking (One-to-Many)

        modelBuilder.Entity<Attendee>()
            .HasMany(a => a.BookingHistory)
            .WithOne(b => b.Attendee)
            .HasForeignKey(b => b.AttendeeID);


        // Configuring inheritance (Table-per-Hierarchy)
        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasDiscriminator<string>("EventType")
                .HasValue<Conference>("Conference")
                .HasValue<Wedding>("Wedding")
                .HasValue<Concert>("Concert");
        });
    }


}