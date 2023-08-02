using AutoMapper;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using RentACar.Business.Abstract;
using RentACar.DAL.Abstract;
using RentACar.Entities.Concrete;
using RentACar.Entities.Concrete.Dtos.Cars;

namespace RentACar.Business.Concrete
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;
        public CarService(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<IResult> Add(CarCreateDto carDto)
        {
            Car car = _mapper.Map<Car>(carDto);
            if (car is null)
            {
                return new ErrorResult("Not Added");
            }

            await _carRepository.AddAsync(car);
            return new SuccessResult("Added");
        }

        public async Task<IResult> Delete(Car car)
        {
            if (car is null)
            {
                return new ErrorResult("Not Added");
            }

            await _carRepository.DeleteAsync(car);
            return new SuccessResult("Deleted");
        }

        public async Task<IResult> DeleteById(int id)
        {
            //CarGetDto carDto = await GetById(id);
            //Car car = _mapper.Map<Car>(carDto);
            //if (car is not null)
            //{
            //    await _carRepository.DeleteAsync(car);
            //}
            return null;
        }

        public async Task<IDataResult<List<CarGetDto>>> GetAll()
        {
            var cars = await _carRepository.GetAllAsync(includes: new string[] { "Brand", "Color" });
            return new SuccessDataResult<List<CarGetDto>>
                (_mapper.Map<List<CarGetDto>>(cars), "Car Listed");
        }

        public async Task<IDataResult<CarGetDto>> GetById(int id)
        {
            Car car = await _carRepository.GetAsync(c => c.Id == id, includes: new string[] { "Brand", "Color" });
            return new SuccessDataResult<CarGetDto>
                (_mapper.Map<CarGetDto>(car));
        }

        public async Task<IDataResult<bool>> IsExistsById(int id)
        {
           return new SuccessDataResult<bool> (await _carRepository.IsExistsAsync(c => c.Id == id));
        }

        public async Task<IDataResult<bool>> IsExistsByName(string name)
        {
            return new SuccessDataResult<bool>  (await _carRepository.IsExistsAsync(c => c.Name == name));
        }

        public async Task<IResult> Update(CarUpdateDto carDto)
        {
            Car existsCar = await _carRepository.GetAsync(c => c.Id == carDto.Id);
            if (existsCar is not null)
            {
                Car car = _mapper.Map(carDto, existsCar);
                await _carRepository.UpdateAsync(car);
            }

            return new SuccessResult("Updated");
        }
    }
}
