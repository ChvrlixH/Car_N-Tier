using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Business.Abstract;
using RentACar.Entities.Concrete;
using RentACar.Entities.Concrete.Dtos.Cars;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _carService.GetAll();
            if (result.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(CarCreateDto carCreateDto)
        {
            Car car = new Car
            {
                Name = carCreateDto.Name,
                BrandId= carCreateDto.BrandId,
                ColorId = carCreateDto.ColorId,
                ModelYear= carCreateDto.ModelYear,
                DailyPrice=carCreateDto.DailyPrice,
                Description=carCreateDto.Description,   
                IsDeleted = false,
                Count = carCreateDto.Count

            };
            await _carService.Add(car);
            return Ok();
        }

    }
}
