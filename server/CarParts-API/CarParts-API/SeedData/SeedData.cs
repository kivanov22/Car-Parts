using Car_Parts_API.Infrastructure.Data.Models;
using System;

namespace CarParts_API.SeedData
{
    public class SeedData
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using (var context = serviceProvider.GetRequiredService<CarPartsContext>())
            {
                context.Database.Migrate();

                if (!context.VehicleTypes.Any())
                {
                    context.VehicleTypes.AddRange(
                        new VehicleType
                        {
                            Category = "Truck",
                        },
                        new VehicleType
                        {
                            Category = "Car",
                        },
                         new VehicleType
                         {
                             Category = "Motorcycle",
                         }
                    );
                    context.SaveChanges();
                }

                if (!context.VehicleMakes.Any())
                {
                    context.VehicleMakes.AddRange(
                        new VehicleMake
                        {
                            MakeName = "BMW",
                        },
                        new VehicleMake
                        {
                            MakeName = "Mercedes",
                        },
                         new VehicleMake
                         {
                             MakeName = "Audi",
                         }
                    );
                    context.SaveChanges();
                }

                if (!context.VehicleModels.Any())
                {
                    context.VehicleModels.AddRange(
                        new VehicleModel
                        {
                            ModelName = "X5",
                            Year = 2005,
                            Description ="Jeep",
                        },
                        new VehicleModel
                        {
                            ModelName = "C200",
                            Year = 2001,
                            Description = "Petrol",
                        },
                         new VehicleModel
                         {
                             ModelName = "A3",
                             Year = 2001,
                             Description = "Automatic",
                         }
                    );
                    context.SaveChanges();
                }


                if (!context.Parts.Any())
                {
                    context.Parts.AddRange(
                        new Part
                        {
                            PartName = "Transmission",
                            PartNumber = 123123,
                            PartDescription = "asdasda",
                            PartBrand = "Bosch",
                            PartTypeId = 3,
                        },
                        new Part
                        {
                            PartName = "Engine",
                            PartNumber = 123123,
                            PartDescription = "asdasda",
                            PartBrand = "Bosch",
                            PartTypeId = 3,
                        },
                         new Part
                         {
                             PartName = "Suspension",
                             PartNumber = 123123,
                             PartDescription = "asdasda",
                             PartBrand = "Bosch",
                             PartTypeId = 3,
                         }
                    );
                    context.SaveChanges();
                }

                if (!context.Inventories.Any())
                {
                    context.Inventories.AddRange(

                        new Inventory
                        {

                        },
                        new Inventory
                         {

                         },
                        new Inventory
                          {

                          }

                        );



                    context.SaveChanges();
                }
            }
        }
    }


}
