using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce_API.Entities
{
    public class ProductType
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

    }
    public class ProductTypeEntityTypeConfiguration : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(70);

            builder.HasData(new List<ProductType>() 
            {
                new ProductType() { Id = 1, Name = "Maillots"},
                new ProductType() { Id = 1, Name = "Shorts"},
                new ProductType() { Id = 1, Name = "Crampons"},
                new ProductType() { Id = 1, Name = "Vestes"},
                new ProductType() { Id = 1, Name = "Ballons"},
            });
        }
    }

    


}