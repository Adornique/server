using server.Adornique.Domain.Models;

namespace server.Adornique.Domain.Services
{
    public interface ICrudService<T>
    {
        Task<IEnumerable<T>> ListAsync();
        Task<T> FindByIdAsync(int id);
        Task SaveAsync(T entity);
        Task UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);
    }
}
