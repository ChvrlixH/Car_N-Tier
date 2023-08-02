using FluentValidation;
using RentACar.Business.Abstract;
using RentACar.Entities.Concrete.Dtos.Cars;
using System.ComponentModel;

namespace RentACar.Business.Utilities.Validators.Cars
{
    public class CarUpdateDtoValidator : AbstractValidator<CarUpdateDto>
    {
        //private readonly ICarService _carService;

        //public CarUpdateDtoValidator(ICarService carService)
        //{
        //    _carService = carService;
        //}

        //public CarUpdateDtoValidator()
        //{ 
        //    RuleFor(c=>c.Name).MustAsync(CheckCarIsExists).WithMessage("Car is already exist");          
        //}

        //public async Task<bool> CheckCarIsExists(string name, CancellationToken cancellationToken)
        //{
        //    return await _carService.IsExistsByName(name);
        //}
    }
}
