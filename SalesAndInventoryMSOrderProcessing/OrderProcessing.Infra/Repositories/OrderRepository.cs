using Microsoft.EntityFrameworkCore;
using OrderProcessing.Application.Dtos;
using OrderProcessing.Application.Interfaces;
using OrderProcessing.Core.Entities;
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

        public async Task CreateOrderAsync(Order order)
        {
            var newOrder = new Order();
            newOrder.OrderDate = order.OrderDate;
            newOrder.CustomerId = order.CustomerId;
            dbContext.Orders.Add(newOrder);
            await dbContext.SaveChangesAsync();

            if (order.OrderItems != null)
            {
                foreach (var item in order.OrderItems)
                {
                    var orderItems = new OrderItem();
                    orderItems.ItemId = item.ItemId;
                    orderItems.Quantity = item.Quantity;
                    orderItems.Rate = item.Rate;
                    orderItems.DiscountAmount = 0;
                    orderItems.Total = item.Total;
                    orderItems.OrderId = newOrder.OrderId;
                    dbContext.OrderItems.Add(orderItems);
                }
            }
           await dbContext.SaveChangesAsync();
        }

        public async Task DeleteOrderAsync(int Id)
        {
            var existingOrder = await dbContext.Orders.FindAsync(Id);
            if(existingOrder != null)
            {
                dbContext.Remove(existingOrder);
                dbContext.SaveChanges();
            }
        }
       
        public async Task EditOrderAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Order>> GetAllOrderAsync()
        {
            var allOrders = dbContext.Orders.Include(x => x.OrderItems);
            return await allOrders.ToListAsync();
        }

        public async Task<Order?> GetOrderByIdAsync(int Id)
        {
            return await dbContext.Orders.Where(x => x.OrderId == Id).Include(p=>p.OrderItems)
                .FirstOrDefaultAsync();
            
        }
    }
}
