using System.ComponentModel.DataAnnotations;
using CarParts.API.Core.ViewModels.Inventory;
using CarParts.API.Core.ViewModels.Vehicle;

namespace CarParts.API.Core.ViewModels.Parts
{
    public class AllPartsDto
    {
        public int Id { get; set; }

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
        public double Size { get; set; }

        [Required]
        public string Condition { get; set; }

        [Required]
        public string PartBrand { get; set; }

        public VehicleMakeDto VehicleMake { get; set; }

        public VehicleModelDto VehicleModel { get; set; }

        public PriceDto Price { get; set; }

    }
}
