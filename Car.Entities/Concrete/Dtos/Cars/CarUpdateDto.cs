using Core.Utilities.Entities.Abstract;

namespace RentACar.Entities.Concrete.Dtos.Cars
{
    public class CarUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
    }
}
