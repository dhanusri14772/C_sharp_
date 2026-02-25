using System.ComponentModel.DataAnnotations;
namespace LocalIntegrationDemo.Models
{
    public class Order
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        public string? CustomerName { get; set; }
        [Required]
        public string? Product { get; set; }
        [Range(1,1000)]
        public int Quantity { get; set; }
    }
}