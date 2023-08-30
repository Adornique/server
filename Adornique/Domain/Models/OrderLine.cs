namespace server.Adornique.Domain.Models
{
    public class OrderLine
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        // Relationship
        public Order? Order { get; set; }
        public int OrderId { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
