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
        public string GetOrder()
        {
            var result = orderRepository.GetOrder();
            return result + "and form application.";
        }
    }
}
