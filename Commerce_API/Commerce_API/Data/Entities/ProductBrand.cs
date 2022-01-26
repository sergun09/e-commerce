using Commerce_API.Data.Entities;

namespace Commerce_API.Entities
{
    public class ProductBrand : BaseEntity
    {
        public string Name { get; set; } = String.Empty;
    }

    public class ProductBrandEntityTypeConfiguration : IEntityTypeConfiguration<ProductBrand>
    {
        public void Configure(EntityTypeBuilder<ProductBrand> builder)
        {
            // Configuration de la table
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(70);



            // Data Seeding
            builder.HasData(new List<ProductBrand>() 
            {
                new(){ Id = 1, Name = "Puma"},
                new(){ Id = 2, Name = "Adidas"},
                new(){ Id = 3, Name = "Nike"}
            });
        }
    }
}