global using CarParts.API.Infrastructure.Data;
global using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

//var connection = builder.Configuration["ConnectionStrings:localhost"];
builder.Services.AddControllers();
builder.Services.AddDbContext<CarPartsContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



//builder.Services.AddTransient<DataSeeder>();


var app = builder.Build();


//Configure(app);
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



app.Run();

//void Configure(WebApplication host)
//{
//    using var scope = host.Services.CreateScope();
//    var services = scope.ServiceProvider;

//    try
//    {
//        var dbContext = services.GetRequiredService<CarPartsContext>();

//        if (dbContext.Database.IsMySql())
//        {
//            dbContext.Database.Migrate();
//        }

//        //var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
//        //var roleManager = services.GetRequiredService<RoleManager<ApplicationRole>>();
//        DataSeeder.Seed(dbContext);
//    }
//    catch (Exception ex)
//    {
//        //Log some error
//        Console.WriteLine(ex.Message);
//        throw;
//    }
//}