using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Parts_API.Infrastructure.Data.Models
{
    public class Inventory
    {
        //This table would store detailed information about the current inventory of parts, including the
        //quantity on hand, reorder level, and the supplier details.
        [Key]
        public int Id { get; set; }

        public int Quantity { get; set; }

        [Required]
        public  string Location { get; set; }

        public DateTime DeliveryDate { get; set; }

        public string? SupplierDetails { get; set; }

        [ForeignKey("PartId")]
        public int PartId { get; set; }
    }
}
