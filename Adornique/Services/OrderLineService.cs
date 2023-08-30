using server.Adornique.Domain.Models;
using server.Adornique.Domain.Services;

namespace server.Adornique.Services
{
    public class OrderLineService:IOrderLineService
    {
        public Task<IEnumerable<OrderLine>> ListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OrderLine> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(OrderLine entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, OrderLine entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
