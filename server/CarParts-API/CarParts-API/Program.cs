global using CarParts.API.Infrastructure.Data;
global using Microsoft.EntityFrameworkCore;
using CarParts.API.Core.Interfaces;
using CarParts.API.Core.Services;
using CarParts.API.Infrastructure.Data.Repository;
using CarParts_API.SeedData;
using System;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IPartService, PartService>();
//var connection = builder.Configuration["ConnectionStrings:localhost"];
builder.Services.AddControllers();
builder.Services.AddDbContext<CarPartsContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program).Assembly);



//builder.Services.AddTransient<DataSeeder>();


var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //builder.Configuration.AddUserSecrets<Program>();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//Seed Database
//using (var scope = app.Services.CreateScope())
//{
//    var services = scope.ServiceProvider;

//    try
//    {
//        var context = services.GetRequiredService<CarPartsContext>();
//        //                    context.Database.Migrate();
//        context.Database.EnsureCreated();
//        SeedData.Seed(services);
//    }
//    catch (Exception ex)
//    {
//        var logger = services.GetRequiredService<ILogger<Program>>();
//        logger.LogError(ex, "An error occurred seeding the DB. {exceptionMessage}", ex.Message);
//    }
//}

app.Run();
