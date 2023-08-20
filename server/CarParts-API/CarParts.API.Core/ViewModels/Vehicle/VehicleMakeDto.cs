using System.ComponentModel.DataAnnotations;

namespace CarParts.API.Core.ViewModels.Vehicle
{
    public class VehicleMakeDto
    {
        [Required]
        public string MakeName { get; set; }
    }
}
