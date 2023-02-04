using CarParts.API.Core.Interfaces;
using CarParts.API.Core.Services;

namespace CarParts_API.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IPartService, PartService>();

            return services;
        }


        public static IServiceCollection AddApplicationDbContexts(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<CarPartsContext>(options =>
                options.UseSqlServer(connectionString));
            //services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }
    }
}
