namespace GymBookingAPI.Models;
public class Booking
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public int ClassId { get; set; }
    public DateTime BookingDate { get; set; } = DateTime.Now;
}