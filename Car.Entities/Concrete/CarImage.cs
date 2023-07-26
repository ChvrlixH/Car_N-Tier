using RentACar.Entities.Concrete.Common;

namespace RentACar.Entities.Concrete
{
    public class CarImage : BaseAuditableEntity
    {
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; }
        public bool IsMain { get; set; }
    }
}
