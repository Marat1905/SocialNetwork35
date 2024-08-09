using Microsoft.EntityFrameworkCore;
using SocialNetwork.Data.Context;

namespace SocialNetwork.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbContext _db;

        public DbSet<T> Set { get; private set; }

        public Repository(ApplicationDbContext db)
        {
            _db = db;
            var set = _db.Set<T>();
            set.Load();

            Set = set;
        }

        public void Create(T item)
        {
            Set.Add(item);
            _db.SaveChanges();
        }

        public void Delete(T item)
        {
            Set.Remove(item);
            _db.SaveChanges();
        }

        public T Get(int id)
        {
            return Set.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return Set;
        }

        public void Update(T item)
        {
            Set.Update(item);
            _db.SaveChanges();
        }

        public IAsyncEnumerable<T> GetAllAsync()
        {
           return Set.AsAsyncEnumerable();
        }

        public async Task<T> GetAsync(int id)
        {
            return await Set.FindAsync(id);
        }

        public async Task CreateAsync(T item)
        {
           await Set.AddAsync(item);
           await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(T item)
        {
            Set.Update(item);
           await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(T item)
        {
            Set.Remove(item);
            await _db.SaveChangesAsync();
        }
    }
}
