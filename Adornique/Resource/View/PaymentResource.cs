namespace server.Adornique.Resource.View
{
    public class PaymentResource
    {
        public int Id { get; set; }
        public DateTime PaymentDate { get; set; }
        public int PaymentTypeId { get; set; }
        public int OrderId { get; set; }
    }
}
