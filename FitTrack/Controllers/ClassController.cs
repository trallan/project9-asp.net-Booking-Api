using Microsoft.AspNetCore.Mvc;
using GymBookingAPI.Models;
using GymBookingAPI.Services;

namespace GymBookingAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ClassController : ControllerBase
{
    private readonly GymService _service;

    public ClassController(GymService service)
    {
        _service = service;
    }

    [HttpGet]
    public IEnumerable<GymClass> GetAll() => _service.Classes;

    [HttpGet("{id}")]
     public IActionResult Create(GymClass gymClass)
    {
        gymClass.Id = _service.Classes.Count + 1;
        _service.Classes.Add(gymClass);
        return Ok(gymClass);
    }
   
}
