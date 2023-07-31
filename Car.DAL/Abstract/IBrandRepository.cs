using Core.Utilities.DataAccess.Abstract;

namespace RentACar.DAL.Abstract
{
    public interface IBrandRepository : IRepository<Brand>, IAsyncRepository<Brand>
    {
    }
}
