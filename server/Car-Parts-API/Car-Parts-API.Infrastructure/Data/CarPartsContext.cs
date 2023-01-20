using Car_Parts_API.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Car_Parts_API.Infrastructure.Data
{
    public class CarPartsContext:IdentityDbContext<>
    {
        public CarPartsContext(DbContextOptions<CarPartsContext> options)
            :base(options)
        {

        }

        public DbSet<Compatibility> Compatibilities { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Inventory> Inventories { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Part> Parts { get; set; }

        public DbSet<PartManufacturer> PartManufacturers { get; set; }

        public DbSet<PartType> PartTypes { get; set; }

        public DbSet<Price> Prices { get; set; }

        public DbSet<Specification> Specifications { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<VehicleMake> VehicleMakes { get; set; }

        public DbSet<VehicleModel> VehicleModels { get; set; }

        public DbSet<VehiclePart> VehicleParts { get; set; }

        public DbSet<VehicleType> VehicleTypes { get; set; }
    }
}
