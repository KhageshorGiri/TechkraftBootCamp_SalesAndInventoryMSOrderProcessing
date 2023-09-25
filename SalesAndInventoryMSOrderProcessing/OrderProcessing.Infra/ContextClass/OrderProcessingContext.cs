using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }

}
