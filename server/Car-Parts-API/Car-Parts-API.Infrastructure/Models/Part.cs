namespace Car_Parts_API.Infrastructure.Models
{
    public class Part
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public required string PartName { get; set; }

        public int PartNumber { get; set; }

        public string PartDescription { get; set; }
    }
}
