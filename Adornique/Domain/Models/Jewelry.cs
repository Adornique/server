namespace server.Adornique.Domain.Models
{
    public class Jewelry
    {
        public string Material { get; set; } = string.Empty;

        // Relationship
        public Product? Product { get; set; }
        public int ProductId { get; set; }
    }
}
