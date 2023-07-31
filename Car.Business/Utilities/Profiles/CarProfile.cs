using AutoMapper;
using RentACar.Entities.Concrete;
using RentACar.Entities.Concrete.Dtos.Cars;

namespace RentACar.Business.Utilities.Profiles
{
    public class CarProfile : Profile
    {
        public CarProfile()
        {
            CreateMap<CarCreateDto, Car>();
            CreateMap<CarUpdateDto, Car>();
            CreateMap<Car, CarGetDto>().ReverseMap();
        }
    }
}
