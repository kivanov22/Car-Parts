using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Parts_API.Infrastructure.Data.Models
{
    public class VehicleModel
    {
        //"Model ID" - a unique identifier for each model, serves as the primary key of the table

        [Key]
        public int Id { get; set; }


        public required string ModelName { get; set; }

        public int Year { get; set; }

        public string Description { get; set; }

        [ForeignKey("MakeId")]
        public int MakeId { get; set; }
    }
}
