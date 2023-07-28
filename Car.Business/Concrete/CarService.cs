using RentACar.Business.Abstract;
using RentACar.DAL.Abstract;
using RentACar.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business.Concrete
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task Add(Car car)
        {
            if (car is not null)
            {
                await _carRepository.AddAsync(car);
            }
        }

        public async Task Delete(Car car)
        {
            if (car is not null)
            {
                await _carRepository.DeleteAsync(car);
            }
        }

        public async Task DeleteById(int id)
        {
            Car car = await GetById(id);
            if (car is not null)
            {
                await _carRepository.DeleteAsync(car);
            }
        }

        public async Task<List<Car>> GetAll()
        {
            return await _carRepository.GetAllAsync(includes: new string[] { "Brand", "Color" });
        }

        public async Task<Car> GetById(int id)
        {
            return await _carRepository.GetAsync(c => c.Id == id, new string[] { "Brand", "Color" });
        }

        public async Task<bool> IsExistsById(int id)
        {
           return await _carRepository.IsExistsAsync(c => c.Id == id);
        }

        public async Task Update(Car car)
        {
            if (car is not null)
            {
                await _carRepository.UpdateAsync(car);
            }
        }
    }
}
