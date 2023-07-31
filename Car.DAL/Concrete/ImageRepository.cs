using Core.Utilities.DataAccess.Concrete.EfCore;
using RentACar.DAL.Abstract;
using RentACar.DAL.Persistance.Context.EfCore;

namespace RentACar.DAL.Concrete
{
    public class ImageRepository : EfBaseRepository<Image, AppDbContext>, IImageRepository
    {
        public ImageRepository(AppDbContext context) : base(context)
        {
        }
    }
}
