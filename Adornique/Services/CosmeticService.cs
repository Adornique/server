using server.Adornique.Domain.Models;
using server.Adornique.Domain.Services;

namespace server.Adornique.Services
{
    public class CosmeticService:ICosmeticService
    {
        public Task<IEnumerable<Cosmetic>> ListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Cosmetic> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(Cosmetic entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, Cosmetic entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
