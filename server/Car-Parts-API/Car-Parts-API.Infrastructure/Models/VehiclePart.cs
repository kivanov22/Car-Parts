using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Parts_API.Infrastructure.Models
{
    public class VehiclePart
    {
        //This table would establish a many-to-many relationship between the Vehicles and Parts table,
        //linking the specific parts used in each vehicle, including the quantity and
        //location of the part on the vehicle.
        [Key]
        public int Id { get; set; }

        public required string PartName { get; set; }

        public int PartNumber { get; set; }

        [ForeignKey("SpecificationId")]
        public int SpecificationId { get; set; }

        public Specification Specification { get; set; }

        [ForeignKey("PartId")]
        public int PartId { get; set; }

        public ICollection<Part> Part { get; init; } = new List<Part>();
    }
}
