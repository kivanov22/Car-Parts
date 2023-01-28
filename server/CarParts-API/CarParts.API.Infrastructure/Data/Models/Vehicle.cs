using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Parts_API.Infrastructure.Data.Models
{
    public class Vehicle
    {
        //This table would contain detailed information about the different makes and models of vehicles that
        //the database tracks, such as make, model, year, engine size, transmission, and drivetrain.
        [Key]
        public int Id { get; set; }

        [Required]
        public  string Make { get; set; }

        [Required]
        public  string Model { get; set; }

        public int Year { get; set; }

        public string? Transmission { get; set; }

        public int HorsePower { get; set; }

        [ForeignKey("VehicleTypeId")]
        public int VehicleTypeId { get; set; }
        public VehicleType VehicleType { get; set; }
    }
}
