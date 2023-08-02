using Core.Utilities.Results.Abstract;
using RentACar.Entities.Concrete;
using RentACar.Entities.Concrete.Dtos.Cars;

namespace RentACar.Business.Abstract
{
    public interface ICarService
    {
        Task<IDataResult<List<CarGetDto>>> GetAll();
        Task<IDataResult<CarGetDto>> GetById(int id);
        Task<IResult> Add(CarCreateDto carDto);
        Task<IResult> Update(CarUpdateDto carDto);
        Task<IResult> DeleteById(int id);
        Task<IResult> Delete(Car car);
        Task<IDataResult<bool>> IsExistsById(int id);
        Task<IDataResult<bool>> IsExistsByName(string name);
    }
}
