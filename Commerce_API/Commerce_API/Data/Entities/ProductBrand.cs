using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce_API.Entities
{
    public class ProductBrand
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
    }

    public class ProductBrandEntityTypeConfiguration : IEntityTypeConfiguration<ProductBrand>
    {
        public void Configure(EntityTypeBuilder<ProductBrand> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(70);
            builder.HasData(new List<ProductBrand>() 
            {
                new(){ Id = 1, Name = "Puma"},
                new(){ Id = 2, Name = "Adidas"},
                new(){ Id = 2, Name = "Nike"}
            });
        }
    }
}