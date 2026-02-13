using Microsoft.AspNetCore.Mvc;
using SampleWebApp.Models;

namespace SampleWebApp.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase {

        private static List<Student> _students = new List<Student> {
            new Student { Id = 1, Name = "Finn", Age = 26, Grade = 80 },
            new Student { Id = 2, Name = "Phil", Age = 28, Grade = 65 },
            new Student { Id = 3, Name = "Tim", Age = 23, Grade = 45 }
        };

        [HttpGet]
        public IActionResult DisplayDetails() {
            return Ok(_students);
        }

        [HttpGet("{id}/status")]
        public IActionResult IsPassed(int id) {
            var student = _students.FirstOrDefault(s => s.Id == id);
            return Ok(new {
                Name = student.Name,
                Passed = student.Grade >= 50 ? "Pass" : "Fail"
            });
        }
    }
}
