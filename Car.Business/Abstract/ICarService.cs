using RentACar.Entities.Concrete;
using RentACar.Entities.Concrete.Dtos.Cars;

namespace RentACar.Business.Abstract
{
    public interface ICarService
    {
        Task<List<CarGetDto>> GetAll();
        Task<CarGetDto> GetById(int id);
        Task Add(CarCreateDto carDto);
        Task Update(CarUpdateDto carDto);
        Task DeleteById(int id);
        Task Delete(Car car);   
        Task<bool> IsExistsById(int id);
    }
}
