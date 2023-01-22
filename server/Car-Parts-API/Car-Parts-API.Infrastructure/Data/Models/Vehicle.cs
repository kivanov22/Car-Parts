using System.ComponentModel.DataAnnotations;

namespace Car_Parts_API.Infrastructure.Data.Models
{
    public class Vehicle
    {
        //This table would contain detailed information about the different makes and models of vehicles that
        //the database tracks, such as make, model, year, engine size, transmission, and drivetrain.
        [Key]
        public int Id { get; set; }
        public required string Make { get; set; }

        public required string Model { get; set; }

        public int Year { get; set; }

        public string? Transmission { get; set; }

        public int HorsePower { get; set; }
    }
}
