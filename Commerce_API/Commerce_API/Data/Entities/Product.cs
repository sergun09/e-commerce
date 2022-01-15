using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Commerce_API.Data.Seed;

namespace Commerce_API.Entities
{
    public class Product
    {
        public int Id { get; set; }

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
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Price).HasPrecision(12,10);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Description).IsRequired().HasColumnType("ntext");
            builder.Property(p => p.ImageUrl).IsRequired();
        }
    }
}
