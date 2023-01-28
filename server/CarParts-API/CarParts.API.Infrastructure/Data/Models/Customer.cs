using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Parts_API.Infrastructure.Data.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public  string Name { get; set; }

        public string? Address { get; set; }

        public int PhoneNumber { get; set; }

        [Required]
        public  string Email { get; set; }

        //public required string Password { get; set; }

        //[ForeignKey("OrderId")]
        //public int OrderId { get; set; }

        public Order Orders { get; set; }

        public string Notes { get; set; }
    }
}
