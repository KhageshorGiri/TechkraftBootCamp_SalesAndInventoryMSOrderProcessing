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
        Task GetAllOrderAsync();

        Task CreateOrderAsync(Order newOrder);

        Task EditOrderAsync();

        Task DeleteOrderAsync();
    }
}
