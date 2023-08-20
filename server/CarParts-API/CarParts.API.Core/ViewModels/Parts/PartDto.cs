using Car_Parts_API.Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using CarParts.API.Core.ViewModels.Vehicle;
using CarParts.API.Core.ViewModels.Inventory;

namespace CarParts.API.Core.ViewModels.Parts
{
    public class PartDto
    {

        [Required]
        public string PartName { get; set; }

        public int PartNumber { get; set; }

        public string? PartDescription { get; set; }

        [Required]
        public string CoverImage { get; set; }

        [Required]
        public string Images { get; set; }

        [Required]
        public string Category { get; set; }

        public string? Material { get; set; }
        public string? Size { get; set; }

        [Required]
        public string Condition { get; set; }

        [Required]
        public string PartBrand { get; set; }

        public VehicleMakeDto VehicleMake { get; set; }//string

        public VehicleModelDto VehicleModel { get; set; }//string

        public PriceDto Price { get; set; }//float
    }
}
