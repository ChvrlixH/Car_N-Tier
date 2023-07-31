using Core.Utilities.DataAccess.Abstract;

namespace RentACar.DAL.Abstract
{
    public interface ICarRepository : IRepository<Car>, IAsyncRepository<Car>
    {
        Car CustomGetById(int id);
    }

}
