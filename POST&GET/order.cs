namespace Integration.Models
{
    public class Order
    {
        public int orderId {get; set;}
        public string? customer {get; set;}
        public decimal amount {get; set;}
    }
}