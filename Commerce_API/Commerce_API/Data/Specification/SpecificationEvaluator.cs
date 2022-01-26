namespace Commerce_API.Data.Specification
{
    public class SpecificationEvaluator<TEntity> where TEntity : BaseEntity
    {
        public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> queryInput, ISpecification<TEntity> spec) 
        {   
            var query = queryInput;

            if(spec.Criteria != null)
                query = query.Where(spec.Criteria); // 

            query = spec.Includes.Aggregate(query, (entity, include) => entity.Include(include));

            return query;
        }
    }
}
