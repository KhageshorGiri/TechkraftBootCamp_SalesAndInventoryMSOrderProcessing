using Microsoft.EntityFrameworkCore;
using OrderProcessing.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing.Infra.ContextClass
{
    public class OrderProcessingContext : DbContext
    {
        public OrderProcessingContext(DbContextOptions<OrderProcessingContext> options)
            : base(options)
        {

          
        }
        public DbSet<Order> orders { get; set; } = null!;
        public DbSet<OrderItem> orderItems { get; set; } = null!;
        public DbSet<Customer> customers { get; set; } = null!;
        public DbSet<Item> items { get; set; } = null!;
        public DbSet<DiscountRule> discountRules { get; set; } = null!;
        public DbSet<ItemDiscount> itemDiscounts { get; set; } = null!;
    }

}
