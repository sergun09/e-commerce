using Commerce_API.Data.Entities;

namespace Commerce_API.Entities
{
    public class Product : BaseEntity
    {
        
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public ProductBrand? ProductBrand { get; set; }

        public int ProductBrandId { get; set; }

        public ProductType? ProductType { get; set; }

        public int ProductTypeId { get; set; }

    }

    partial class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // Configuration de la table
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Price).HasPrecision(10,2);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Description).IsRequired().HasColumnType("ntext");
            builder.Property(p => p.ImageUrl).IsRequired();

            // Configration des relations
            builder.HasOne(p => p.ProductBrand)
                   .WithMany()
                   .HasForeignKey(p => p.ProductBrandId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.ProductType)
                   .WithMany()
                   .HasForeignKey(p => p.ProductTypeId)
                   .OnDelete(DeleteBehavior.Restrict);


            // Data Seeding
            builder.HasData(new List<Product>() 
            {
                new(){ Id= 1, Name = "Product 1", Description = "Description product 1", ImageUrl = "https://dummyimage.com/250x250", Price = 9.99m,
                    ProductBrandId = 1, ProductTypeId = 1},
                new(){ Id= 2, Name = "Product 2", Description = "Description product 2", ImageUrl = "https://dummyimage.com/250x250", Price = 13.99m,
                    ProductBrandId = 1, ProductTypeId = 3},
                new(){ Id= 3, Name = "Product 1", Description = "Description product 1", ImageUrl = "https://dummyimage.com/250x250", Price = 19.39m,
                    ProductBrandId = 2, ProductTypeId = 2},
                new(){ Id= 4, Name = "Product 1", Description = "Description product 1", ImageUrl = "https://dummyimage.com/250x250", Price = 25.49m,
                    ProductBrandId = 2, ProductTypeId = 4},
                new(){ Id= 5, Name = "Product 1", Description = "Description product 1", ImageUrl = "https://dummyimage.com/250x250", Price = 80.99m,
                    ProductBrandId = 3, ProductTypeId = 5}


            });
        }
    }
}
