using OrderProcessing.Application.Interfaces;


namespace OrderProcessing.Application.Services
{
    public class OrderService : IOrder
    {
        private readonly IOrderRepository orderRepository;
        public OrderService(IOrderRepository _orderRepository)
        {
            this.orderRepository = _orderRepository;
        }

        public async Task CreateOrderAsync()
        {
            throw new NotImplementedException();
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
