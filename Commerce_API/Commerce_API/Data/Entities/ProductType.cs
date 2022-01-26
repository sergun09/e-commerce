using Commerce_API.Data.Entities;

namespace Commerce_API.Entities
{
    public class ProductType : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

    }
    public class ProductTypeEntityTypeConfiguration : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
            // Configuration de la table
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(70);


            // Data Seeding
            builder.HasData(new List<ProductType>() 
            {
                new ProductType() { Id = 1, Name = "Maillots"},
                new ProductType() { Id = 2, Name = "Shorts"},
                new ProductType() { Id = 3, Name = "Crampons"},
                new ProductType() { Id = 4, Name = "Vestes"},
                new ProductType() { Id = 5, Name = "Ballons"},
            });
        }
    }

    


}