using RentACar.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business.Abstract
{
    public interface IBrandService
    {
        Task<List<Brand>> GetAll();
        Task<Brand> GetById(int id);
        Task Add(Brand brand);
        Task Update(Brand brand);
        Task DeleteById(int id);
        Task Delete(Brand brand);
        Task<bool> IsExistsById(int id);
    }
}
