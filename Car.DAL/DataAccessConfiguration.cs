using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RentACar.DAL.Persistance.Context.EfCore;
using RentACar.DAL.Persistance.Interceptors;

namespace RentACar.DAL
{
    public static class DataAccessConfiguration
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpContextAccessor();
            services.AddDbContext<AppDbContext>(opt =>
            opt.UseSqlServer(configuration.GetConnectionString("Default")));
            services.AddScoped<BaseAuditableEntityInterceptor>();
            return services;
        }
    }
}
