using System.ComponentModel.DataAnnotations;

namespace OrderProcessing.Application.Dtos
{
    public record GetOrderDto
    {
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public List<OrderItemDto>? OrderItems { get; set; }
    }

    public record CreateOrderDto
    {
        public int CustomerId { get; set; }
        public List<OrderItemDto>? OrderItems { get; set; }
    }

    public record EditOrderDto
    {
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
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
