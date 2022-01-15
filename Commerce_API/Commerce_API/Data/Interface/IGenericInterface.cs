namespace Commerce_API.Data.Interface
{
    public interface IGenericInterface<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAllItemsAsync();
        Task<T> GetItemAsync();

    }
}
