using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Parts_API.Infrastructure.Data.Models
{
    public class Part
    {
        [Key]
        public int Id { get; set; }


        public required string PartName { get; set; }

        public int PartNumber { get; set; }

        public string? PartDescription { get; set; }

        public required string PartBrand { get; set; }

        [ForeignKey("PartTypeId")]
        public int PartTypeId { get; set; }

        public PartType PartTypes { get; set; }

        //public int Warranty { get; set; }

        //public string Notes { get; set; }
    }
}
