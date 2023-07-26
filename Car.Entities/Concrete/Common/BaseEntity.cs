using Core.Utilities.Entities.Abstract;

namespace RentACar.Entities.Concrete.Common
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}
