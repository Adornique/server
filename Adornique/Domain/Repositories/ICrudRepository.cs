using server.Adornique.Domain.Models;

namespace server.Adornique.Domain.Repositories
{
    public interface ICrudRepository<T>
    {
        Task<IEnumerable<T>> ListAsync();
        Task<T> FindByIdAsync(int id);
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
