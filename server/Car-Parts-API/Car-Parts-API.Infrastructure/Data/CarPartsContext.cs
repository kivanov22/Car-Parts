using Car_Parts_API.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Car_Parts_API.Infrastructure.Data
{
    public class CarPartsContext:DbContext
    {
        protected readonly IConfiguration Configuration;

        public CarPartsContext(DbContextOptions<CarPartsContext> options, IConfiguration configuration)
            : base(options)
        {
            Configuration = configuration;
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


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var connectionString = Configuration.GetConnectionString("DBConnection");
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
