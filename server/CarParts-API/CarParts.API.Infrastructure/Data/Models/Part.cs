using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Parts_API.Infrastructure.Data.Models
{
    public class Part
    {
        public Part()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public  string PartName { get; set; }

        public int PartNumber { get; set; }

        public string? PartDescription { get; set; }

        [Required]
        public string CoverImage { get; set; }

        [Required]
        public string Images { get; set; }

        [Required]
        public string Category { get; set; }

        public string? Material { get; set; }
        public string? Size { get; set; }

        [Required]
        public string Condition { get; set; }

        public DateTime CreatedOn { get; set; }

        [Required]
        public  string PartBrand { get; set; }

        [ForeignKey("PartTypeId")]
        public int PartTypeId { get; set; }

        public PartType PartTypes { get; set; }

        public VehicleMake VehicleMake { get; set; }
        public VehicleModel VehicleModel { get; set; }
        public Price Price { get; set; }
    }
}
//public int Warranty { get; set; }

//public string Notes { get; set; }