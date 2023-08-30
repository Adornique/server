namespace server.Adornique.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public decimal TotalAmount { get; set; }
        public string ShippingAddress { get; set; } = string.Empty;
        public string BillingAddress { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Relationship
        public Customer? Customer { get; set; }
        public int CustomerId { get; set; }
        public StatusOrder? StatusOrder { get; set; }
        public int StatusOrderId { get; set; }
        public List<OrderLine> OrderLines { get; set; } = new List<OrderLine>();
        public List<Payment> Payments { get; set; } = new List<Payment>();
    }
}
