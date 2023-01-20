namespace Car_Parts_API.Infrastructure.Models
{
    public class Vehicle
    {
        //This table would contain detailed information about the different makes and models of vehicles that
        //the database tracks, such as make, model, year, engine size, transmission, and drivetrain.

        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Make { get; set; }

        public required string Model { get; set; }

        public int Year { get; set; }

        public string? Transmission { get; set; }

        public int HorsePower { get; set; }
    }
}
