using GymBookingAPI.Models;

namespace GymBookingAPI.Services;

public class GymService
{
    public List<Customer> Customers { get; } = new()
    {
        new Customer { Id = 1, Name = "Anna Andersson", Email = "anna@test.com" },
        new Customer { Id = 2, Name = "Björn Berg", Email = "bjorn@test.com" }
    };

    public List<GymClass> Classes { get; } = new()
    {
        new GymClass { Id = 1, Title = "Yoga", Description = "Lugn och ro", StartTime = DateTime.Now.AddHours(1) },
        new GymClass { Id = 2, Title = "HIIT", Description = "Högintensiv träning", StartTime = DateTime.Now.AddHours(2) }
    };

    public List<Booking> Bookings { get; } = new();
}
