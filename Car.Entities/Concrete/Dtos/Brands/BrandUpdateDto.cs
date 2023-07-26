using Core.Utilities.Entities.Abstract;

namespace RentACar.Entities.Concrete.Dtos.Brands
{
    public class BrandUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
