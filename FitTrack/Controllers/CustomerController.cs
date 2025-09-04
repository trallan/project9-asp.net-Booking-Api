using Microsoft.AspNetCore.Mvc;
using GymBookingAPI.Models;

namespace GymBookingAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
    private static List<Customer> customers = new List<Customer>
    {
        new Customer { Id = 1, Name = "Anna Andersson", Email = "anna@test.com" },
        new Customer { Id = 2, Name = "Björn Berg", Email = "bjorn@test.com" }
    };

    [HttpGet]
    public IEnumerable<Customer> GetAll() => customers;

    [HttpGet("{id}")]
    public ActionResult<Customer> GetById(int id)
    {
        var customer = customers.FirstOrDefault(c => c.Id == id);
        if (customer == null) return NotFound();
        return customer;
    }

    [HttpPost]
    public IActionResult Create(Customer customer)
    {
        customer.Id = customers.Count + 1;
        customers.Add(customer);
        return CreatedAtAction(nameof(GetById), new { id = customer.Id }, customer);
    }
}
