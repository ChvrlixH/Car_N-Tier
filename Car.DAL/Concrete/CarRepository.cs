using Core.Utilities.DataAccess.Concrete.EfCore;
using RentACar.DAL.Abstract;
using RentACar.DAL.Persistance.Context.EfCore;


namespace RentACar.DAL.Concrete
{
    public class CarRepository : EfBaseRepository<Car, AppDbContext>, ICarRepository
    {
        private readonly AppDbContext _context;
        public CarRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public Car CustomGetById(int id)
        {
            return _context.Cars.Find(id);
        }
    }
}
