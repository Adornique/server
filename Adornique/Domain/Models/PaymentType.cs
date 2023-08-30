namespace server.Adornique.Domain.Models
{
    public class PaymentType
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // Relationship
        public List<Payment> Payments { get; set; } = new List<Payment>();
    }
}
