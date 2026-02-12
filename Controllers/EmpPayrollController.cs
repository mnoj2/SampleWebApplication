using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleWebApp.Models;

namespace SampleWebApp.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class EmpPayrollController : ControllerBase {

        [HttpGet("summary")]
        public IActionResult GetPayroll() {
            List<Emp> staff = new List<Emp>
            {
               new PermanentEmp { Name = "Alice", MonthlyPay = 5000 },
               new ContractEmp { Name = "Bob", HourlyRate = 40, HoursWorked = 160 }
            };

            var results = new List<object>();
            foreach(var person in staff) {
                results.Add(new {
                    Name = person.Name,
                    TotalSalary = person.CalculateSalary()
                });
            }

            return Ok(results);
        }
    }
}
