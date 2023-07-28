using RentACar.DAL.Abstract;
using RentACar.DAL.Persistance.Context.EfCore;
using System.Linq.Expressions;


namespace RentACar.DAL.Concrete
{
    public class CarRepository : ICarRepository
    {
        private readonly AppDbContext _context;

        public CarRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Car> AddAsync(Car car, CancellationToken cancellationToken = default)
        {
            await _context.Cars.AddAsync(car);
            await _context.SaveChangesAsync(cancellationToken);
            return car;
        }

        public async Task<Car> DeleteAsync(Car car, CancellationToken cancellationToken = default)
        {
            _context.Cars.Remove(car);
            await _context.SaveChangesAsync(cancellationToken);
            return car;
        }

        public async Task<Car> GetAsync(Expression<Func<Car, bool>> predicate, string[] includes = null, bool tracking = true, CancellationToken cancellationToken = default)
        {
            IQueryable<Car> query = GetQuery();
            query = AddIncludesToQuery(includes, query);
            if (!tracking) 
            {
                query = query.AsNoTracking();
            }
            return await query.Where(predicate).FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<List<Car>> GetAllAsync(Expression<Func<Car, bool>> predicate = null, string[] includes = null, bool tracking = true, CancellationToken cancellationToken = default)
        {
            IQueryable<Car> query = GetQuery();
            query = AddIncludesToQuery(includes, query);
            if (!tracking)
            {
                query = query.AsNoTracking();
            }
            return predicate != null
                ? await query.Where(predicate).ToListAsync(cancellationToken)
                : await query.ToListAsync(cancellationToken);
        }

        public async Task<bool> IsExistsAsync(Expression<Func<Car, bool>> predicate, CancellationToken cancellationToken = default)
        {
            IQueryable<Car> query = GetQuery();
            return await query.AnyAsync(predicate, cancellationToken);
        }

        public async Task<Car> UpdateAsync(Car car, CancellationToken cancellationToken = default)
        {
            _context.Cars.Update(car);
            await _context.SaveChangesAsync(cancellationToken);
            return car;
        }


        private DbSet<Car> GetQuery()
        {
            return _context.Set<Car>();
        }

        private static IQueryable<Car> AddIncludesToQuery(string[] includes, IQueryable<Car> query)
        {
            foreach (string include in includes)
            {
                query = query.Include(include);
            }

            return query;
        }
    }
}
