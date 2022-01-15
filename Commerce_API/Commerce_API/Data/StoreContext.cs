using Commerce_API.Entities;

namespace Commerce_API.Data
{
    public class StoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<ProductBrand> ProductBrands { get; set; }

        public DbSet<ProductType> ProductTypes { get; set; }
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        public StoreContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StoreContext).Assembly);
        }


    }
}
