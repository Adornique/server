namespace server.Adornique.Domain.Models
{
    public class Customer
    {
        public User? User { get; set; }
        public int UserId { get; set; }

        // Relationship
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
