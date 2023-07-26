using Core.Utilities.Entities.Abstract;

namespace RentACar.Entities.Concrete.Dtos.Brands
{
    public class BrandGetDto :IDto
    {
        public BrandGetDto()
        {
            Cars = new List<Car>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Car> Cars { get; set; }
    }
}
