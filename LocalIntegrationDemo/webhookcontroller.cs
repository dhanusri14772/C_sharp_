using Microsoft.AspNetCore.Mvc;
namespace LocalIntegrationDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Webhookcontroller : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> ReceiveWebhook([FromBody] object payload)
        {
            Console.WriteLine("webhook received");
            await Task.Delay(10000);
            return Ok(new
            {
                message = "webhook received successfully",
                receivedAt = DateTime.UtcNow
            });
        }
    }
}