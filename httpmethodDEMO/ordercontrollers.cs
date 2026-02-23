using Microsoft.AspNetCore.Mvc;
using LocalIntegrationDemo.Models;
namespace LocalIntegrationDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private static List<Order> orders = new List<Order>();
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
        public IActionResult CreateOrder(Order order)
        {
            orders.Add(order);
            return CreatedAtAction(nameof(GetOrderById),
                                   new { id = order.Id },
                                   order);
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
    }
}