namespace Car_Parts_API.Infrastructure.Data.Models
{
    public class Compatibility
    {
        public int PartId { get; set; }

        public Part Part { get; set; }

        public int ModelId { get; set; }

        public VehicleModel VehicleModel { get; set; }
    }
}
