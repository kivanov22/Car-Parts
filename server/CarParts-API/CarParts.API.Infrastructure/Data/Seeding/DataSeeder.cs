using Car_Parts_API.Infrastructure.Data.Models;

namespace CarParts.API.Infrastructure.Data.Seeding
{
    public class DataSeeder
    {
        private readonly CarPartsContext _context;

        public DataSeeder(CarPartsContext context)
        {
            _context= context;
        }


        public static void Seed(CarPartsContext context)
        {
            if (!context.VehicleTypes.Any())
            {
                var vehicleTypes = new List<VehicleType>()
                {
                    new VehicleType()
                    {
                        Category = "Truck"
                    },
                    new VehicleType()
                    {
                        Category = "Car"
                    },
                    new VehicleType()
                    {
                        Category = "Motorcycle"
                    }
                };
                context.VehicleTypes.AddRange(vehicleTypes);
                context.SaveChanges();
            }
        }
    }
}
