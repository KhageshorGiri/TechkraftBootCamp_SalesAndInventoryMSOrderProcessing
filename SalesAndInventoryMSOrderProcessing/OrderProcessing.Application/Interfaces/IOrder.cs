using OrderProcessing.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing.Application.Interfaces
{
    public interface IOrder
    {
        Task GetAllOrderAsync();

        Task CreateOrderAsync(CreateOrderDto order);

        Task EditOrderAsync();

        Task DeleteOrderAsync();
       
    }
}
