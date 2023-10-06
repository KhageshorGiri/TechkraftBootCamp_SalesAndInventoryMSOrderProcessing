using OrderProcessing.Application.Dtos;
using OrderProcessing.Core.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing.Application.Interfaces
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetAllOrderAsync();

        Task<Order?> GetOrderByIdAsync(int Id);

        Task CreateOrderAsync(Order newOrder);

        Task EditOrderAsync();

        Task DeleteOrderAsync(int Id);
    }
}
