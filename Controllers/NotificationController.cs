using Microsoft.AspNetCore.Mvc;
using SampleWebApp.Models;

namespace SampleWebApp.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase {

        [HttpPost("send")]
        public IActionResult SendNotifications() {

            Notification email = new EmailNotification {
                RecipientEmail = "abc@gmail.com",
                Message = "Welcome to abc"
            };

            Notification sms = new SMSNotification {
                PhoneNumber = "7904976644",
                Message = "Your OTP is 3544"
            };

            var results = new List<string> {
                email.Send(),
                sms.Send()
            };

            return Ok(results);
        }
    }
}
