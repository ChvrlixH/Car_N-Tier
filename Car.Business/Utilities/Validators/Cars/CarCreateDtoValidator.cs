using FluentValidation;
using RentACar.Entities.Concrete.Dtos.Cars;

namespace RentACar.Business.Utilities.Validators.Cars
{
    public class CarCreateDtoValidator : AbstractValidator<CarCreateDto>
    {
        public CarCreateDtoValidator()
        {
            RuleFor(c => c.Name)
                      .NotEmpty().WithMessage("Car name must not be empty!")
                      .NotNull().WithMessage("Car name must not be null!")
                      .MinimumLength(1).WithMessage("Must be a minimum of 2 characters!")
                      .MaximumLength(100).WithMessage("The maximum can be 100 characters")
                      .Must(CheckName).WithMessage("Name must start with 'a'!");
            RuleFor(c => c.DailyPrice)
                      .GreaterThanOrEqualTo(1000).WithMessage("The price must be at least $1000")
                      .LessThanOrEqualTo(1000000).WithMessage("The price can be a maximum of $1,000,000");
        }
        public bool CheckName(string name)
        {
            return name.ToLower().StartsWith("a");
        }
    }
}
