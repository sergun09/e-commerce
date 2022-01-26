using Commerce_API.Data.Repository;

namespace Commerce_API.Data.Specification
{
    public class ProductSpecification : BaseSpecification<Product>
    {
        public ProductSpecification()
        {
            AddInclude(p => p.ProductType);
            AddInclude(p => p.ProductBrand);
        }
    }
}
