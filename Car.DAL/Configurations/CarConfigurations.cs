
namespace RentACar.DAL.Configurations
{
    public class CarConfigurations : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(90).IsRequired();
            builder.HasCheckConstraint<Car>("ModelYear", "ModelYear between 1980 and 2023");
        }
    }
}
