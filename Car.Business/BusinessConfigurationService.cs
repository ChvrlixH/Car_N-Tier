using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using RentACar.Business.Abstract;
using RentACar.Business.Concrete;
using System.Reflection;
namespace RentACar.Business
{
    public static class BusinessConfigurationService
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection service)
        {
            service.AddScoped<ICarService, CarService>();
            service.AddAutoMapper(Assembly.GetExecutingAssembly());
            service.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            return service;
        }
    }
}
