namespace server.Adornique.Resource.View
{
    public class OrderLineResource
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int OrderId { get; set; }
    }
}
