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
        public string Name { get; set; } = null!;

        public string Address { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber {  get; set; } = null!;   
        public bool IsActive { get; set; } 
    }
}
