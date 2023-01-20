using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Parts_API.Infrastructure.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public required string Name { get; set; }

        public string? Address { get; set; }

        public int PhoneNumber { get; set; }

        public required string Email { get; set; }

        //public required string Password { get; set; }

        [ForeignKey("OrderId")]
        public int OrderId { get; set; }

        public Order Orders { get; set; }

        public string Notes { get; set; }
    }
}
