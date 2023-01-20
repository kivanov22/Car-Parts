namespace Car_Parts_API.Infrastructure.Models
{
    public class Compatibility
    {
        public int PartId { get; set; }

        public Part Part { get; set; }

        public int ModelId { get; set; }

        public VehicleModel Vehicle_Model { get; set; }
    }
}
