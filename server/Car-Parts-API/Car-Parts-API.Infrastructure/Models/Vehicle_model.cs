using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Parts_API.Infrastructure.Models
{
    public class Vehicle_model
    {
        //"Model ID" - a unique identifier for each model, serves as the primary key of the table

        public Guid ModelId { get; set; } = Guid.NewGuid();

        [ForeignKey("MakeId")]
        public int MakeId { get; set; }

        public required string ModelName { get; set; }

        public int Year { get; set; }

        public string Description { get; set; }
    }
}
