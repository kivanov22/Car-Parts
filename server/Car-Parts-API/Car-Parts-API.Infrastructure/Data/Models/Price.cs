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

        public required string Currency { get; set; }

        public required string Availability { get; set; }

        public decimal ShippingCost { get; set; }

        public int PartNumber { get; set; }

        public required string Part_Name { get; set; }

        public required string ManufacturerName { get; set; }

        public string Notes { get; set; }

        [ForeignKey("PartId")]
        public int PartId { get; set; }

        public Part Part { get; set; }
    }
}
