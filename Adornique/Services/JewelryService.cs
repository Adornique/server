using server.Adornique.Domain.Models;
using server.Adornique.Domain.Services;

namespace server.Adornique.Services
{
    public class JewelryService:IJewelryService
    {
        public Task<IEnumerable<Jewelry>> ListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Jewelry> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(Jewelry entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, Jewelry entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
