namespace BazresiApi.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAsync(long id);
        void add(T entity);

        Task SaveAsync();
    }
}
