using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleWebApp.Models;

namespace SampleWebApp.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase {

        [HttpPost("pay")]
        public IActionResult Pay([FromBody] PaymentDto request) {

            IPayment paymentProcessor;
            string type = request.Type;
            decimal amount = request.Amount;

            switch(type.ToLower()) {
                case "credit":
                    paymentProcessor = new CreditCardPayment();
                    break;
                case "upi":
                    paymentProcessor = new UPIPayment();
                    break;
                default:
                    paymentProcessor = new CashPayment();
                    break;
            }

            string result = paymentProcessor.ProcessPayment(amount);

            return Ok(new { Status = result });
        }
    }
}
