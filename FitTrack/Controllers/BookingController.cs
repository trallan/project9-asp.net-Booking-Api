using Microsoft.AspNetCore.Mvc;
using GymBookingAPI.Models;

namespace GymBookingAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookingsController : ControllerBase
{
    private static List<Customer> customers = new List<Customer>
    {
        new Customer { Id = 1, Name = "Anna Andersson", Email = "anna@test.com" },
        new Customer { Id = 2, Name = "Björn Berg", Email = "bjorn@test.com" }
    };

    private static List<GymClass> classes = new List<GymClass>
    {
        new GymClass { Id = 1, Title = "Yoga", Description = "Lugn och ro", StartTime = DateTime.Now.AddHours(1) },
        new GymClass { Id = 2, Title = "HIIT", Description = "Högintensiv träning", StartTime = DateTime.Now.AddHours(2) }
    };

    private static List<Booking> bookings = new List<Booking>
    {
        new Booking { Id = 1, CustomerId = 2, ClassId = 1},
        new Booking { Id = 2, CustomerId = 2, ClassId = 1},
    };

    [HttpGet]
    public IEnumerable<Booking> GetAll() => bookings;

    [HttpPost]
    public IActionResult Create(Booking booking)
    {
        // kontrollera att kund & klass finns
        if (!customers.Any(c => c.Id == booking.CustomerId))
            return BadRequest("Customer not found");
        if (!classes.Any(c => c.Id == booking.ClassId))
            return BadRequest("Class not found");

        // kontrollera dubbelbokning
        if (bookings.Any(b => b.CustomerId == booking.CustomerId && b.ClassId == booking.ClassId))
            return BadRequest("Customer already booked this class");

        booking.Id = bookings.Count + 1;
        booking.BookingDate = DateTime.Now;
        bookings.Add(booking);

        return CreatedAtAction(nameof(GetAll), new { id = booking.Id }, booking);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Booking updateBooking)
    {
        var booking = bookings.FirstOrDefault(b => b.Id == id);
        if (booking == null) return NotFound();

        booking.ClassId = updateBooking.ClassId;

        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var booking = bookings.FirstOrDefault(b => b.Id == id);
        if (booking == null) return NotFound();
        bookings.Remove(booking);

        return NoContent();
    }
}
