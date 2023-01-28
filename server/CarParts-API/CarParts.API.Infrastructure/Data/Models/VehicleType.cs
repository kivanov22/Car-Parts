using System.ComponentModel.DataAnnotations;

namespace Car_Parts_API.Infrastructure.Data.Models
{
    public class VehicleType
    {
        //Car,truck,bike
        [Key]
        public int Id { get; set; }

        [Required]
        public  string Category { get; set; }

        public ICollection<Vehicle> Vehicles { get; init; } = new List<Vehicle>();
    }
}
