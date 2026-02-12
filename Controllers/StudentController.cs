using Microsoft.AspNetCore.Mvc;
using SampleWebApp.Models;

namespace SampleWebApp.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase {

        private static List<Student> _students = new List<Student> {
            new Student { Id = 1, Name = "Cal", Age = 20, Grade = 85 },
            new Student { Id = 2, Name = "Phil", Age = 21, Grade = 62 }
        };

        [HttpGet]
        public IActionResult GetAllStudents() {
            return Ok(_students);
        }

        [HttpGet("{id}/status")]
        public IActionResult GetStudentStatus(int id) {
            var student = _students.FirstOrDefault(s => s.Id == id);
            return Ok(new {
                Name = student.Name,
                Passed = student.Grade >= 50 ? "Pass" : "Fail"
            });
        }
    }
}
