using Microsoft.AspNetCore.Mvc;
using SampleWebApp.Models;

namespace SampleWebApp.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase {

        [HttpPost("send-test")]
        public IActionResult SendNotifications() {
            Notification email = new EmailNotification {
                RecipientEmail = "user@example.com",
                Message = "Welcome to our platform!"
            };

            Notification sms = new SMSNotification {
                PhoneNumber = "123-456-7890",
                Message = "Your OTP is 4432"
            };

            var results = new List<string> {
                email.Send(),
                sms.Send()
            };

            return Ok(results);
        }
    }
}
