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

        public async Task DeleteOrderAsync(int Id)
        {
            await orderRepository.DeleteOrderAsync(Id);
        }

        public async Task EditOrderAsync()
        {
            await orderRepository.EditOrderAsync();
        }

        public async Task<List<GetOrderDto>> GetAllOrderAsync()
        {
            var allOrders = await orderRepository.GetAllOrderAsync();

            List<GetOrderDto> allOrderDetails = new List<GetOrderDto>();

            foreach(var order in allOrders)
            {
                GetOrderDto getAllOrder = new()
                {
                    CustomerId = Convert.ToInt32(order.CustomerId),
                    OrderId = order.OrderId,
                    OrderDate = order.OrderDate
                    
                };
                if (order.OrderItems != null)
                {
                    foreach (var items in order.OrderItems)
                    {
                        OrderItemDto orderItem = new()
                        {
                            ItemId = items.ItemId,
                            Quantity = items.Quantity,
                            Rate = Convert.ToDecimal(items.Rate),
                            DiscountRateId = items.DiscountRateId
                        };
                        getAllOrder.OrderItems?.Add(orderItem);
                    }
                }
                allOrderDetails.Add(getAllOrder);
            }

            return allOrderDetails;
        }

        public async Task<GetOrderDto> GetOrderByIdAsync(int Id)
        {
            var singleOrder = await orderRepository.GetOrderByIdAsync(Id);

            GetOrderDto existingOrder = new()
            {
                CustomerId = Convert.ToInt32(singleOrder?.CustomerId),
                OrderId = Convert.ToInt32(singleOrder?.OrderId),
                OrderDate = singleOrder?.OrderDate
            };
            if (existingOrder.OrderItems != null)
            {
                foreach (var items in existingOrder.OrderItems)
                {
                    OrderItemDto orderItem = new()
                    {
                        ItemId = items.ItemId,
                        Quantity = items.Quantity,
                        Rate = Convert.ToDecimal(items.Rate),
                        DiscountRateId = items.DiscountRateId
                    };
                    existingOrder.OrderItems?.Add(orderItem);
                }
            }
            return existingOrder;
        }
    }
}
