using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing.Core.Entities
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MembershipId { get; set; }
        public bool IsActive { get; set; } 
    }
}
