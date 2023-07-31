﻿using AutoMapper;
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

        public async Task Add(CarCreateDto carDto)
        {
            Car car = _mapper.Map<Car>(carDto);
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
            CarGetDto carDto = await GetById(id);
            Car car = _mapper.Map<Car>(carDto);
            if (car is not null)
            {
                await _carRepository.DeleteAsync(car);
            }
        }

        public async Task<List<CarGetDto>> GetAll()
        {
            var cars = await _carRepository.GetAllAsync(includes: new string[] { "Brand", "Color" });
            return _mapper.Map<List<CarGetDto>>(cars);
        }

        public async Task<CarGetDto> GetById(int id)
        {
            Car car = await _carRepository.GetAsync(c => c.Id == id, includes: new string[] { "Brand", "Color" });
            return _mapper.Map<CarGetDto>(car);
        }

        public async Task<bool> IsExistsById(int id)
        {
           return await _carRepository.IsExistsAsync(c => c.Id == id);
        }

        public async Task Update(CarUpdateDto carDto)
        {
            Car existsCar = await _carRepository.GetAsync(c => c.Id == carDto.Id);
            if (existsCar is not null)
            {
                Car car = _mapper.Map(carDto, existsCar);
                await _carRepository.UpdateAsync(car);
            }
        }
    }
}
