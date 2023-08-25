using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Parts_API.Infrastructure.Data.Models
{
    public class Order
    {
        public Order()
        {
            Id = Guid.NewGuid();
        }
        //This table would store detailed information about customer orders, including customer information, order date,
        //shipping address, and the specific parts that were ordered along with their quantity.
        [Key]
        public Guid Id { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Today;

        public int Quantity { get; set; }

        public decimal TotalCost { get; set; }

        [Required]
        public  string PaymentMethod { get; set; }

        [Required]
        public  string ShippingAddress { get; set; }

        [Required]
        public  string Status { get; set; }

        public string? Notes { get; set; }

        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        [ForeignKey("PartId")]
        public int PartId { get; set; }

        public Part Part { get; set; }
    }
}
