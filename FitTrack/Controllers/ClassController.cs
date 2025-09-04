using Microsoft.AspNetCore.Mvc;
using GymBookingAPI.Models;

namespace GymBookingAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClassController : ControllerBase
{
    private static List<GymClass> classes = new List<GymClass>
    {
        new GymClass { Id = 1, Title = "Yoga", Description = "Lugn och ro", StartTime = DateTime.Now.AddHours(1) },
        new GymClass { Id = 2, Title = "HIIT", Description = "Högintensiv träning", StartTime = DateTime.Now.AddHours(2) }
    };

    [HttpGet]
    public IEnumerable<GymClass> GetAll() => classes;

    [HttpGet("{id}")]
    public ActionResult<GymClass> GetById(int id)
    {
        var gymClass = classes.FirstOrDefault(c => c.Id == id);
        if (gymClass == null) return NotFound();
        return gymClass;
    }

    [HttpPost]
    public IActionResult Create(GymClass gymClass)
    {
        gymClass.Id = classes.Count + 1;
        classes.Add(gymClass);
        return CreatedAtAction(nameof(GetById), new { id = gymClass.Id }, gymClass);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, GymClass updatedClass)
    {
        var gymClass = classes.FirstOrDefault(c => c.Id == id);
        if (gymClass == null) return NotFound();

        gymClass.Title = updatedClass.Title;
        gymClass.Description = updatedClass.Description;
        gymClass.StartTime = updatedClass.StartTime;

        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var gymClass = classes.FirstOrDefault(c => c.Id == id);
        if (gymClass == null) return NotFound();
        
        classes.Remove(gymClass);

        return NoContent();
    }
}
