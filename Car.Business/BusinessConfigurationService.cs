using Microsoft.Extensions.DependencyInjection;
using RentACar.Business.Abstract;
using RentACar.Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business
{
    public static class BusinessConfigurationService
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection service)
        {
            service.AddScoped<ICarService, CarService>();
            return service;
        }
    }
}
