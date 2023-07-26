using RentACar.Entities.Concrete.Common;

namespace RentACar.Entities.Concrete
{
    public class Color : BaseEntity
    {
        public Color()
        {
            Colors = new List<Car>();
        }
        public string Name { get; set; }
        public List<Car> Colors { get; set;}
    }
}
