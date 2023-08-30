namespace server.Adornique.Resource.Create
{
    public class SavePaymentResource
    {
        public DateTime PaymentDate { get; set; }
        public int PaymentTypeId { get; set; }
        public int OrderId { get; set; }
    }
}
