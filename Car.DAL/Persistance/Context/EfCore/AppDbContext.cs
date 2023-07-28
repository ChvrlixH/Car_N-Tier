using RentACar.DAL.Persistance.Interceptors;
using System.Reflection;


namespace RentACar.DAL.Persistance.Context.EfCore
{
    public class AppDbContext : DbContext
    {
        private readonly BaseAuditableEntityInterceptor _baseAuditableEntityInterceptor;
        public AppDbContext(DbContextOptions<AppDbContext> options, BaseAuditableEntityInterceptor baseAuditableEntityInterceptor) : base(options) 
        {
            _baseAuditableEntityInterceptor = baseAuditableEntityInterceptor;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.AddInterceptors(_baseAuditableEntityInterceptor);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-0ETCTHF\MSSQLSERVER01;Database=RentACar;Trusted_Connection=true;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Image> Images { get; set; }

    }
}
