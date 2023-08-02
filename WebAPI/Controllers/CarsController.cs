using Microsoft.AspNetCore.Mvc;
using RentACar.Business.Abstract;
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
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(CarCreateDto carCreateDto)
        {
            var result = await _carService.Add(carCreateDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(CarUpdateDto carUpdateDto)
        {
           var result = await _carService.Update(carUpdateDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
