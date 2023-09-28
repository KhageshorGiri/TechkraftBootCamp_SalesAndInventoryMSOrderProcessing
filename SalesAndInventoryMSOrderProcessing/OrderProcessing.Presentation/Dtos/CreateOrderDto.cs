namespace OrderProcessing.Presentation.Dtos
{
    public record CreateOrderDto
    {
        public int? CustomerId { get; set; }
        public decimal? GrandTotal { get; set; }

        public int? ItemId { get; set; }
        public int Quantity { get; set; }
        public decimal? Rate { get; set; }
        public int? DiscountRateId { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? Total { get; set; }
    }
}
