global using CarParts.API.Infrastructure.Data;
global using Microsoft.EntityFrameworkCore;
using CarParts.API.Core.Auth.JwtUtils;
using CarParts.API.Core.Helpers;
using CarParts.API.Core.Interfaces;
using CarParts.API.Core.Services;
using CarParts.API.Infrastructure.Data.Repository;
using CarParts_API.Controllers;
using CarParts_API.Middlewares;
using CarParts_API.SeedData;
using System;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
{
    var services = builder.Services;
    var env = builder.Environment;

    //var connection = builder.Configuration["ConnectionStrings:localhost"];

    services.AddControllers()
            .AddJsonOptions(x => x.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull);

    services.AddScoped<IUnitOfWork, UnitOfWork>();
    services.AddScoped<IPartService, PartService>();
    services.AddScoped<IJwtUtils, JwtUtils>();
    services.AddScoped<IUserService, UserService>();

    // configure strongly typed settings object
    services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));


    services.AddDbContext<CarPartsContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

});
    services.AddCors();

    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();
    services.AddAutoMapper(
                                typeof(IPartService).Assembly,
                                typeof(PartController).Assembly);

}


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

// configure HTTP request pipeline
{
    // global cors policy
    app.UseCors(x => x
        .SetIsOriginAllowed(origin => true)
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials());

    // global error handler
    app.UseMiddleware<ErrorHandlerMiddleware>();

    // custom jwt auth middleware
    app.UseMiddleware<JwtMiddleware>();

    app.MapControllers();
}

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
