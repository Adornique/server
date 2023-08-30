namespace server.Adornique.Domain.Models
{
    public class StatusOrder
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // Relationship
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
