using OrderProcessing.Application.Dtos;
using OrderProcessing.Application.Interfaces;
using OrderProcessing.Core.Entities;

namespace OrderProcessing.Application.Services
{
    public class OrderService : IOrder
    {
        private readonly IOrderRepository orderRepository;
        public OrderService(IOrderRepository _orderRepository)
        {
            this.orderRepository = _orderRepository;
        }

        public async Task CreateOrderAsync(CreateOrderDto order)
        {
            var newOrder = new Order();
            newOrder.OrderDate = DateTime.UtcNow;
            newOrder.CustomerId = order.CustomerId;

            if (order.OrderItems != null)
            {
                foreach (var item in order.OrderItems)
                {
                    var orderItems = new OrderItem();
                    orderItems.OrderItemId = item.ItemId;
                    orderItems.Quantity = item.Quantity;
                    orderItems.Rate = item.Rate;
                    orderItems.DiscountAmount = 0;
                    orderItems.Total = (item.Rate * item.Quantity) - orderItems.DiscountAmount;
                    newOrder.OrderItems?.Add(orderItems);
                }
            }
            await orderRepository.CreateOrderAsync(newOrder);
        }

        public async Task DeleteOrderAsync()
        {
            throw new NotImplementedException();
        }

        public async Task EditOrderAsync()
        {
            throw new NotImplementedException();
        }

        public async Task GetAllOrderAsync()
        {
            throw new NotImplementedException();
        }
    }
}
