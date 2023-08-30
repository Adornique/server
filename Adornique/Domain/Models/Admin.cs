namespace server.Adornique.Domain.Models
{
    public class Admin
    {
        public User? User { get; set; }
        public int UserId { get; set; }

        // Relationship
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
