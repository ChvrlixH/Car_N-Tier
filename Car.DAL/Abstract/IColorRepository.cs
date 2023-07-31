using Core.Utilities.DataAccess.Abstract;

namespace RentACar.DAL.Abstract
{
    public interface IColorRepository : IRepository<Color>, IAsyncRepository<Color>
    {
    }
}
