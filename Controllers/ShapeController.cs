using Microsoft.AspNetCore.Mvc;
using SampleWebApp.Models;

namespace SampleWebApp.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ShapeController : ControllerBase {

        List<Shape> shapes = new List<Shape> {
                new Circle { Radius = 5 },
                new Rectangle { Length = 10, Width = 5 }
        };

        [HttpGet("calculate-circle")]
        public IActionResult GetAreaCircle() {

            return Ok(new { TotalArea = shapes[0].CalculateArea() });
        }

        [HttpGet("calculate-rectangle")]
        public IActionResult GetAreaRectangle() {

            return Ok(new { TotalArea = shapes[1].CalculateArea() });
        }
    }
}
