using Microsoft.EntityFrameworkCore;
using OrderProcessing.Core.Entities;

namespace OrderProcessing.Infra.ContextClass
{
    public class OrderProcessingContext : DbContext
    {
        public OrderProcessingContext(DbContextOptions<OrderProcessingContext> options)
            : base(options)
        {
          
        }

        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderItem> OrderItems { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Item> Items { get; set; } = null!;
        public DbSet<DiscountRule> DiscountRules { get; set; } = null!;
        public DbSet<ItemDiscount> ItemDiscounts { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<OrderProcess> OrderProcesses { get; set; } = null!;
    }

}
