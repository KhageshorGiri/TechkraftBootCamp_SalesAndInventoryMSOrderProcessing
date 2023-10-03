using System.ComponentModel.DataAnnotations;

namespace OrderProcessing.Application.Dtos
{
    public record CreateOrderDto
    {
        public int CustomerId { get; set; }
        public List<OrderItemDto>? OrderItems { get; set; }
    }


    public class OrderItemDto
    {
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public decimal Rate { get; set; }
        public int DiscountRateId { get; set; }
    }
}
