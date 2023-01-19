namespace Car_Parts_API.Infrastructure.Models
{
    public class Part
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public int PartTypeId { get; set; }

        public Part_Types Part_Types { get; set; }
        public required string PartName { get; set; }

        public int PartNumber { get; set; }

        public string PartDescription { get; set; }

        public string PartBrand { get; set; }

        //public int Warranty { get; set; }

        //public string Notes { get; set; }
    }
}
