using Core.Utilities.Entities.Abstract;

namespace RentACar.Entities.Concrete.Dtos.Cars
{
    public class CarGetDto : IDto
    {
        public CarGetDto()
        {
            CarImages = new List<CarImage>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public Brand? Brand { get; set; }
        public Color? Color { get; set; }
        public List<CarImage>? CarImages { get; set; }
    }
}
