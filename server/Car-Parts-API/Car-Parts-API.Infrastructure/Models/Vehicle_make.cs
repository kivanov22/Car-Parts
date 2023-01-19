using System.ComponentModel.DataAnnotations;

namespace Car_Parts_API.Infrastructure.Models
{
    public class Vehicle_make
    {
        //"Make ID" - a foreign key that corresponds to the primary key of a "make" table, linking a specific model to a specific make of car
        [Key]
        public int MakeId { get; set; }

        public required string MakeName { get; set; }

    }
}
