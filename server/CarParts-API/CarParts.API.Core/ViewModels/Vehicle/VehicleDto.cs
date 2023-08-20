using Car_Parts_API.Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarParts.API.Core.ViewModels.Vehicle
{
    public class VehicleDto
    {
        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        public int Year { get; set; }

        public string? Transmission { get; set; }

        public int HorsePower { get; set; }

    }
}
