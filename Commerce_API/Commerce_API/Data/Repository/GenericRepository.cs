using Commerce_API.Data.Interface;
using Commerce_API.Data.Specification;

namespace Commerce_API.Data.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly StoreContext context;

        public GenericRepository(StoreContext context)
        {
            this.context = context;
        }

        public async Task<IReadOnlyList<T>> GetAllItemsAsync(ISpecification<T> spec)
        {
            return await ApplySpec(spec).ToListAsync();
        }

        public async Task<T> GetItemAsync(ISpecification<T> spec)
        {
            return await ApplySpec(spec).FirstOrDefaultAsync();
        }

        private IQueryable<T> ApplySpec(ISpecification<T> spec) 
        {
            return SpecificationEvaluator<T>.GetQuery(this.context.Set<T>().AsQueryable(), spec);
        }
    }
}
