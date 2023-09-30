using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing.Core.Entities
{
    public class DiscountRule
    {
        [Key]
        public int DiscountRuleID { get; set; }
        public decimal DiscountValue { get; set; }  
        public int DiscountTypeId { get; set; } 
        public int Dayofweek { get; set; }
    }
}
