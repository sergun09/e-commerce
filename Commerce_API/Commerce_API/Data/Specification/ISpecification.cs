namespace Commerce_API.Data.Specification
{
    public interface ISpecification<T>
    {
        /// <summary>
        /// Retourne une Expression de filtrage (x => x.Name.Contains("S"))
        /// </summary>
        Expression<Func<T, bool>> Criteria { get; }

        /// <summary>
        /// Retourne une liste de tous les includes context.Product.Include(x => x.ProductBrand )
        /// </summary>
        List<Expression<Func<T, object>>> Includes { get; }
    }
}
