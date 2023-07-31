using RentACar.Business.Abstract;
using RentACar.DAL.Abstract;
using RentACar.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business.Concrete
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;

        public BrandService(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public Task Add(Brand brand)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Brand brand)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Brand>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Brand> GetById(int id)
        {
            return await _brandRepository.GetAsync(b => b.Id == id);
        }

        public Task<bool> IsExistsById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}
