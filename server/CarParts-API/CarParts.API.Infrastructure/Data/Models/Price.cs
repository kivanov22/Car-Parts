using global::Car_Parts_API.Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Parts_API.Infrastructure.Data.Models
{
    public class Price
    {
        // this table will store the price of the part, any discounts, and offer for each part along with the
        // currency.
        [Key]
        public int Id { get; set; }

        public decimal PartPrice { get; set; }

        public decimal Discount { get; set; }

        [Required]
        public  string Currency { get; set; }

        [Required]
        public  string Availability { get; set; }

        public decimal ShippingCost { get; set; }

        public int PartNumber { get; set; }

        [Required]
        public  string PartName { get; set; }

        [Required]
        public  string ManufacturerName { get; set; }

        [ForeignKey("PartId")]
        public int PartId { get; set; }
        public Part Part { get; set; }
        public string Notes { get; set; }
    }
}
