using Microsoft.AspNetCore.Mvc;
using SampleWebApp.Models;

namespace SampleWebApp.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ShapeController : ControllerBase {

        [HttpGet("calculate-all")]
        public IActionResult GetTotalArea() {
            List<Shape> shapes = new List<Shape>
            {
            new Circle { Radius = 5 },
            new Rectangle { Length = 10, Width = 5 }
        };

            double totalArea = 0;
            foreach(var shape in shapes) {
                totalArea += shape.CalculateArea();
            }

            return Ok(new { TotalArea = totalArea });
        }
    }
}
