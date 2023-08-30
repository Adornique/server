namespace server.Adornique.Resource.View
{
    public class OrderResource
    {
        public int Id { get; set; }
        public decimal TotalAmount { get; set; }
        public string ShippingAddress { get; set; } = string.Empty;
        public string BillingAddress { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public int CustomerId { get; set; }
        public int StatusOrderId { get; set; }
    }
}
