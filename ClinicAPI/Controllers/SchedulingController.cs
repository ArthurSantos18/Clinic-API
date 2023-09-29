using ClinicAPI.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ClinicAPI.Controllers
{
    [ApiController]
    [Route("api/Controllers")]
    public class SchedulingController : Controller
    {
        List<Scheduling> schedules = new List<Scheduling>(); 
        public SchedulingController()
        {
            schedules.Add(new Scheduling { 
                Id = 1, 
                Name = "Arthur Santos Azevedo", 
                Time = DateTime.Now
            });
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(schedules);
        }

        [HttpGet("{Id}")]
        public IActionResult GetById(int id)
        {
            var schedule = schedules.FirstOrDefault(s => s.Id == id);

            return schedule != null ? Ok(schedule) : NotFound();
        }
    }
}
