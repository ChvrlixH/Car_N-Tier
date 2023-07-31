using Core.Utilities.DataAccess.Concrete.EfCore;
using RentACar.DAL.Abstract;
using RentACar.DAL.Persistance.Context.EfCore;

namespace RentACar.DAL.Concrete
{
    public class CarImageRepository : EfBaseRepository<CarImage, AppDbContext>, ICarImageRepository
    {
        public CarImageRepository(AppDbContext context) : base(context)
        {
        }
    }
}
