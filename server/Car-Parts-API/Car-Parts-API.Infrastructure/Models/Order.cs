using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Parts_API.Infrastructure.Models
{
    public class Order
    {

        //This table would store detailed information about customer orders, including customer information, order date,
        //shipping address, and the specific parts that were ordered along with their quantity.
        [Key]
        public int Id { get; set; }


        public DateTime OrderDate { get; set; }

        public int Quantity { get; set; }

        public decimal TotalCost { get; set; }

        public required string PaymentMethod { get; set; }

        public required string ShippingAddress { get; set; }

        public required string Status { get; set; }

        public string? Notes { get; set; }

        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        [ForeignKey("PartId")]
        public int PartId { get; set; }

        public Part Part { get; set; }
    }
}
