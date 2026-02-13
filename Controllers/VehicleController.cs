using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleWebApp.Models;

namespace SampleWebApp.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase {

        [HttpGet("drive")]
        public IActionResult TestDrive() {

            var myCar = new Car { Brand = "BMW", Speed = 120 };
            var myBike = new Bike { Brand = "Duke", Speed = 80 };

            return Ok(new[] {
                myCar.Start(),
                myBike.Start()
            });
        }
    }
}
