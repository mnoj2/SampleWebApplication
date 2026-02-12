using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleWebApp.Models;

namespace SampleWebApp.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase {
        private static BankAccount _account = new BankAccount(1000); 

        [HttpGet("balance")]
        public IActionResult CheckBalance() {
            return Ok(new { Balance = _account.GetBalance() });
        }

        [HttpPost("deposit")]
        public IActionResult Deposit([FromBody] decimal amount) {
            _account.Deposit(amount);
            return Ok("Deposit successful.");
        }

        [HttpPost("withdraw")]
        public IActionResult Withdraw([FromBody] decimal amount) {
            bool success = _account.Withdraw(amount);
            if(!success)
                return BadRequest("Insufficient funds or invalid amount.");

            return Ok("Withdrawal successful.");
        }
    }
}
