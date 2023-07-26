using RentACar.Entities.Concrete.Common;

namespace RentACar.Entities.Concrete
{
    public class Brand :BaseEntity
    {
        public Brand()
        {
            Cars = new List<Car>();
        }
        public string Name { get; set; }
        public List<Car> Cars { get; set; }

    }
}
