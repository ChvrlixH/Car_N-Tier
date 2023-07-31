using Core.Utilities.DataAccess.Concrete.EfCore;
using RentACar.DAL.Abstract;
using RentACar.DAL.Persistance.Context.EfCore;

namespace RentACar.DAL.Concrete
{
    public class BrandRepository : EfBaseRepository<Brand, AppDbContext>, IBrandRepository
    {
        public BrandRepository(AppDbContext context) : base(context)
        {
        }
    }
}
