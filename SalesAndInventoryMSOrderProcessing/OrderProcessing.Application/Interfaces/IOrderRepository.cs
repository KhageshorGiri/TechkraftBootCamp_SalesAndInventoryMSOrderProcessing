using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing.Application.Interfaces
{
    public interface IOrderRepository
    {
        public string GetOrder();
    }
}
