using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing.Core.Entities
{
    public class ItemDiscount
    {
        public int ItemDiscountId { get; set; }
        public int DiscountRuleID { get; set; }
        public int ItemId { get; set; }
        public bool IsActive { get; set; }
    }
}
