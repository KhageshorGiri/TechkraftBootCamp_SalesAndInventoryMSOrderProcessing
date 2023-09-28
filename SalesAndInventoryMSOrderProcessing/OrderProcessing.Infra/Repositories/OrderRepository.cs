using OrderProcessing.Application.Interfaces;
using OrderProcessing.Infra.ContextClass;
using System;

namespace OrderProcessing.Infra.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderProcessingContext dbContext;

        public OrderRepository(OrderProcessingContext _Context)
        {
            this.dbContext = _Context;
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
