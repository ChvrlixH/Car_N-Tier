
namespace RentACar.Entities.Concrete.Common
{
    public class BaseAuditableEntity : BaseEntity
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
