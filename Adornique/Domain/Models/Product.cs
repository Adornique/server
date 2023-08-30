namespace server.Adornique.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Relationship
        public Admin? Admin { get; set; }
        public int AdminId { get; set; }
        public OrderLine? OrderLine { get; set; }
        public int OrderLineId { get; set; }
        public Cosmetic? Cosmetic { get; set; }
        public Jewelry? Jewelry { get; set; }
    }
}
