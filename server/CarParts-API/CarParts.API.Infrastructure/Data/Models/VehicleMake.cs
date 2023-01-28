using System.ComponentModel.DataAnnotations;

namespace Car_Parts_API.Infrastructure.Data.Models
{
    public class VehicleMake
    {
        //"Make ID" - a foreign key that corresponds to the primary key of a "make" table, linking a specific model to a specific make of car
        [Key]
        public int MakeId { get; set; }

        [Required]
        public  string MakeName { get; set; }

    }
}
