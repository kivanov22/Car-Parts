using Car_Parts_API.Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarParts.API.Core.ViewModels
{
    public class PartDto
    {
        [Required]
        public string PartName { get; set; }

        public int PartNumber { get; set; }

        public string? PartDescription { get; set; }

        [Required]
        public string PartBrand { get; set; }

        [ForeignKey("PartTypeId")]
        public int PartTypeId { get; set; }

        public PartType PartTypes { get; set; }
    }
}
