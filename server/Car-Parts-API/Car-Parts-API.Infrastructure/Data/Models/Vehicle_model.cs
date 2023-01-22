using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Parts_API.Infrastructure.Data.Models
{
    public class Vehicle_model
    {
        //"Model ID" - a unique identifier for each model, serves as the primary key of the table
<<<<<<<< HEAD:server/Car-Parts-API/Car-Parts-API.Infrastructure/Data/Models/Vehicle_model.cs

        public Guid ModelId { get; set; } = Guid.NewGuid();

        [ForeignKey("MakeId")]
        public int MakeId { get; set; }
========
        [Key]
        public int Id { get; set; }
>>>>>>>> 01432d4daee875c3bbd2613ee2eba64ffd36032e:server/Car-Parts-API/Car-Parts-API.Infrastructure/Data/Models/VehicleModel.cs

        public required string ModelName { get; set; }

        public int Year { get; set; }

        public string Description { get; set; }
    }
}
