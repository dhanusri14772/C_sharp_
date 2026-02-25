using Microsoft.AspNetCore.Mvc;
using LocalIntegrationDemo.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace LocalIntegrationDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private static List<Order> orders = new List<Order>();

        private readonly HttpClient _httpClient;

        public OrdersController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("RetryClient");
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public IActionResult GetOrderById(int id)
        {
            var order = orders.FirstOrDefault(o => o.Id == id);

            if (order == null)
                return NotFound($"Order with Id {id} not found");

            return Ok(order);
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrder(Order order)
        {
            orders.Add(order);
        try
        {
            var response = await _httpClient.PostAsJsonAsync(
                "http://localhost:5256/api/webhook",
                order);
            if (!response.IsSuccessStatusCode)
        {
            return StatusCode((int)response.StatusCode, new
            {
                message = "Order saved, but webhook failed",
                webhookStatus = response.StatusCode
            });
        }
            return CreatedAtAction(nameof(GetOrderById),
                                   new { id = order.Id },
                                   new
                                   {
                                       order,
                                       webhookStatus = response.StatusCode
                                   });
        }
        catch (Exception ex)
        {
        return StatusCode(500, new
        {
            message = "Order saved, but webhook call crashed",
            error = ex.Message
        });
        }
        }
        [HttpPut("{id}")]
        public IActionResult UpdateOrder(int id, Order updatedOrder)
        {
            var order = orders.FirstOrDefault(o => o.Id == id);

            if (order == null)
                return NotFound();

            order.CustomerName = updatedOrder.CustomerName;
            order.Product = updatedOrder.Product;
            order.Quantity = updatedOrder.Quantity;
            return Ok(order);
        }

        [HttpPatch("{id}")]
        public IActionResult PatchOrder(int id, [FromBody] Dictionary<string, object> updates)
        {
            var order = orders.FirstOrDefault(o => o.Id == id);
            if (order == null)
                return NotFound();

            if (updates.ContainsKey("customerName"))
                order.CustomerName = updates["customerName"]?.ToString();

            if (updates.ContainsKey("product"))
                order.Product = updates["product"]?.ToString();

            if (updates.ContainsKey("quantity"))
                order.Quantity = Convert.ToInt32(updates["quantity"]);

            return Ok(order);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int id)
        {
            var order = orders.FirstOrDefault(o => o.Id == id);

            if (order == null)
                return NotFound();

            orders.Remove(order);
            return NoContent();
        }

        [HttpHead("{id}")]
        public IActionResult HeadOrder(int id)
        {
            var order = orders.FirstOrDefault(o => o.Id == id);

            if (order == null)
                return NotFound();

            return Ok();
        }
    }
}