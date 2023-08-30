namespace server.Adornique.Resource.Create
{
    public class SaveOrderResource
    {
        public decimal TotalAmount { get; set; }
        public string ShippingAddress { get; set; } = string.Empty;
        public string BillingAddress { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public int CustomerId { get; set; }
        public int StatusOrderId { get; set; }
    }
}
