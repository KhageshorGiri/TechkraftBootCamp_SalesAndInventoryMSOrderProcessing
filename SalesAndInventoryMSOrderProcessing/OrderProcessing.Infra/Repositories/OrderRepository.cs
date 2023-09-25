using OrderProcessing.Application.Interfaces;
using System;

namespace OrderProcessing.Infra.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public string GetOrder()
        {
            return "from infra";
        }
    }
}
