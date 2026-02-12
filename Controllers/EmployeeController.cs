using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleWebApp.Models;

namespace SampleWebApp.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase {

        [HttpGet("calculate")]
        public IActionResult GetSalary() {
            var emp = new Employee(1, "John Doe", 5000);

            return Ok(new {
                Name = emp.Name,
                TotalSalary = emp.CalculateSalary()
            });
        }
    }
}
