using Car_Parts_API.Infrastructure.Data.Models;
using CarParts.API.Infrastructure.Data.Auth;
using Microsoft.EntityFrameworkCore;

namespace CarParts.API.Infrastructure.Data
{
    public class CarPartsContext: DbContext
    {
        public CarPartsContext(DbContextOptions<CarPartsContext> options)
            :base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Compatibility> Compatibilities { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Inventory> Inventories { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Part> Parts { get; set; }

        public DbSet<PartМanufacturer> PartManufacturers { get; set; }

        public DbSet<PartType> PartTypes { get; set; }

        public DbSet<Price> Prices { get; set; }

        public DbSet<Specification> Specifications { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<VehicleMake> VehicleMakes { get; set; }

        public DbSet<VehicleModel> VehicleModels { get; set; }

        public DbSet<VehiclePart> VehicleParts { get; set; }

        public DbSet<VehicleType> VehicleTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Example Fluent Api 
            //modelBuilder.Entity<Customer>()
            //    .HasOne<Order>()
            //    .WithOne()
            //    .HasForeignKey<Customer>(b => b.OrderId)
            //    .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Compatibility>().HasKey(c => new { c.PartId, c.ModelId });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //var connectionString = Configuration.GetConnectionString("ConnectionStrings:CarPartsDb");
            
        }
       

    }
}
