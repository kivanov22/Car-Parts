namespace Car_Parts_API.Infrastructure.Data.Models
{
    public class Vehicle
    {
        //This table would contain detailed information about the different makes and models of vehicles that
        //the database tracks, such as make, model, year, engine size, transmission, and drivetrain.

<<<<<<< HEAD:server/Car-Parts-API/Car-Parts-API.Infrastructure/Models/Vehicle.cs
        public Guid Id { get; set; } = Guid.NewGuid();
=======
        public int Id { get; set; }
>>>>>>> 01432d4daee875c3bbd2613ee2eba64ffd36032e:server/Car-Parts-API/Car-Parts-API.Infrastructure/Data/Models/Vehicle.cs
        public required string Make { get; set; }

        public required string Model { get; set; }

        public int Year { get; set; }

        public string? Transmission { get; set; }

        public int HorsePower { get; set; }
    }
}
