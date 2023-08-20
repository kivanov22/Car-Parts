using System.ComponentModel.DataAnnotations;

namespace CarParts.API.Core.ViewModels.Vehicle
{
    public class VehicleModelDto
    {
        [Required]
        public string ModelName { get; set; }

        public int Year { get; set; }

        public string Description { get; set; }
    }
}
