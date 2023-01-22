namespace Car_Parts_API.Infrastructure.Data.Models
{
    public class PartType
    {
        public int Id { get; set; }

        public required string PartTypeName { get; set; }

        public string? Description { get; set; }
    }
}
