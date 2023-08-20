using Car_Parts_API.Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarParts.API.Core.ViewModels.Inventory
{
    public class PriceDto
    {
        public decimal PartPrice { get; set; }

        public decimal Discount { get; set; }

        [Required]
        public string Currency { get; set; }

        [Required]
        public string Availability { get; set; }

        public decimal ShippingCost { get; set; }

        public int PartNumber { get; set; }

        [Required]
        public string PartName { get; set; }

        [Required]
        public string ManufacturerName { get; set; }


        public string? Notes { get; set; }
    }
}
