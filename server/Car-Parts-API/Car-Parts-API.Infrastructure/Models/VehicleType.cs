using System.ComponentModel.DataAnnotations;

namespace Car_Parts_API.Infrastructure.Models
{
    public class VehicleType
    {
        //Car,truck,bike
        [Key]
        public int Id { get; set; }

        public required string Category { get; set; }
    }
}
