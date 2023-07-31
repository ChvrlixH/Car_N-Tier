using Core.Utilities.DataAccess.Abstract;

namespace RentACar.DAL.Abstract
{
    public interface IImageRepository : IRepository<Image>, IAsyncRepository<Image>
    {
    }
}
