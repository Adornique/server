namespace server.Adornique.Resource.Create
{
    public class SaveProductResource
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int AdminId { get; set; }
        public int OrderLineId { get; set; }
    }
}
