
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Parts_API.Infrastructure.Data.Models
{
    //information about the part
    public class Specification
    {
        [Key]
        public int Id { get; set; }

        public int Year { get; set; }

        public required string Engine { get; set; }
        public int Horsepower { get; set; }
        public required string Transmission { get; set; }

        public required string Drivetrain { get; set; }


        [ForeignKey("MakeId")]
        public int MakeId { get; set; }

        public VehicleMake VehicleMake { get; set; }

        [ForeignKey("ModelId")]
        public int ModelId { get; set; }

        public VehicleModel VehicleModel { get; set; }
    }
}
//A "car specification" table in a car parts database would likely have several fields that store information about the specifications
//of different cars, as well as fields that connect them to other tables such as the "models" and "make" tables. Here's an example of some of
//the fields and properties that the "car specification" table might include:

//    "Model ID" - a foreign key that corresponds to the primary key of the "models" table, linking a specific car specification to a specific model
//    "Make ID" - a foreign key that corresponds to the primary key of the "make" table, linking a specific car specification to a specific make
//    "Year" - the year the car was manufactured
//    "Engine" - the type of engine the car has
//    "Horsepower" - the horsepower of the engine
//    "Torque" - the torque of the engine
//    "Transmission" - the type of transmission the car has
//    "Drivetrain" - the type of drivetrain the car has (FWD, RWD, AWD)
//    "Fuel economy" - the car 's fuel economy
//    "Notes" - Additional information about the car specification