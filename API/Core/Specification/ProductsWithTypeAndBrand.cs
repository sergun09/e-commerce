using Core.Entities;
using System.Linq.Expressions;

namespace Core.Specification
{
    public class ProductsWithTypeAndBrand : BaseSpecification<Product>
    {
        public ProductsWithTypeAndBrand()
        {
            AddIncludes(x => x.ProductType);
            AddIncludes(x => x.ProductBrand);
        }

        public ProductsWithTypeAndBrand(int id) : base(p => p.Id == id)
        {
            AddIncludes(x => x.ProductType);
            AddIncludes(x => x.ProductBrand);
        }
    }
}
