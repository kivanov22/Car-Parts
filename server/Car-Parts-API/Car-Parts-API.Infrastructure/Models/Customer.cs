using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Parts_API.Infrastructure.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int OrderId { get; set; }

        public Order Orders { get; set; }

        public string Notes { get; set; }
    }
}
