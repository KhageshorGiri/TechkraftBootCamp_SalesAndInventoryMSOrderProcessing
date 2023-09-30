using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing.Core.Entities
{
    public class OrderProcess
    {
        public int CustomerID { get; set; }

        public List<Item> itemList { get; set; } = null!;


    }
}
