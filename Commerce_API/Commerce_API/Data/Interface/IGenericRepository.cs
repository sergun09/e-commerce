using Commerce_API.Data.Specification;

namespace Commerce_API.Data.Interface
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<IReadOnlyList<T>> GetAllItemsAsync(ISpecification<T> spec);
        Task<T> GetItemAsync(ISpecification<T> spec);
    }
}
