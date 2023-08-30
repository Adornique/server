using server.Adornique.Domain.Models;
using server.Adornique.Domain.Services;

namespace server.Adornique.Services
{
    public class StatusOrderService:IStatusOrderService
    {
        public Task<IEnumerable<StatusOrder>> ListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<StatusOrder> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(StatusOrder entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, StatusOrder entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
