
namespace RentACar.DAL.Configurations
{
    public class BrandConfigurations : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(90).IsRequired();
            builder.HasIndex(p => p.Name).IsUnique();

            builder.HasMany(c => c.Cars)
               .WithOne(p => p.Brand)
               .HasForeignKey(p => p.BrandId);
        }
    }
}
