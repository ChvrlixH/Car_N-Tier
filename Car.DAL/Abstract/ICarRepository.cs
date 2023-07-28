using RentACar.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DAL.Abstract
{
    public interface ICarRepository
    {
        Task<List<Car>> GetAllAsync(Expression<Func<Car,bool>> predicate=null, string[] includes=null, bool tracking=true, CancellationToken cancellationToken=default);

        Task<Car> GetAsync(Expression<Func<Car, bool>> predicate, string[] includes = null, bool tracking = true, CancellationToken cancellationToken = default);

        Task<Car> AddAsync(Car car, CancellationToken cancellationToken=default);
        Task<Car> UpdateAsync(Car car, CancellationToken cancellationToken=default);
        Task<Car> DeleteAsync(Car car, CancellationToken cancellationToken = default);
        Task<bool> IsExistsAsync(Expression<Func<Car,bool>> predicate, CancellationToken cancellationToken=default);
    }
}
