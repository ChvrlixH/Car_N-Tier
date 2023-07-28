using RentACar.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business.Abstract
{
    public interface ICarService
    {
        Task<List<Car>> GetAll();
        Task<Car> GetById(int id);
        Task Add(Car car);
        Task Update(Car car);
        Task DeleteById(int id);
        Task Delete(Car car);
        Task<bool> IsExistsById(int id);
    }
}
