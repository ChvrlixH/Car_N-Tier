using Core.Utilities.DataAccess.Concrete.EfCore;
using RentACar.DAL.Abstract;
using RentACar.DAL.Persistance.Context.EfCore;

namespace RentACar.DAL.Concrete
{
    public class ColorRepository : EfBaseRepository<Color, AppDbContext>, IColorRepository
    {
        public ColorRepository(AppDbContext context) : base(context)
        {
        }
    }
}
