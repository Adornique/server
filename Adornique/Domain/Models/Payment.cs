namespace server.Adornique.Domain.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public DateTime PaymentDate { get; set; }

        // Relationship
        public PaymentType? PaymentType { get; set; }
        public int PaymentTypeId { get; set; }
        public Order? Order { get; set; }
        public int OrderId { get; set; }
    }
}
