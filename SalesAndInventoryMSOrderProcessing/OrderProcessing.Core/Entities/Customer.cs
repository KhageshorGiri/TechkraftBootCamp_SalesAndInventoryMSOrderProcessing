using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing.Core.Entities
{
    public class Customer
    {

        public int Id { get; set; }
        public int UserId { get; set; }
        public int MembershipId { get; set; }
        public bool IsActive { get; set; } 
    }
}
