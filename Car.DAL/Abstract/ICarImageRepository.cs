using Core.Utilities.DataAccess.Abstract;

namespace RentACar.DAL.Abstract
{
    public interface ICarImageRepository : IRepository<CarImage>, IAsyncRepository<CarImage>
    {
    }
}
