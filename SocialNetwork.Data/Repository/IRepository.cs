namespace SocialNetwork.Data.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Create(T item);
        void Update(T item);
        void Delete(T item);

        IAsyncEnumerable<T> GetAllAsync();

        Task<T> GetAsync(int id);

        Task CreateAsync(T item);

        Task UpdateAsync(T item);

        Task DeleteAsync(T item);
    }
}
