using server.Adornique.Domain.Models;
using server.Adornique.Domain.Services;

namespace server.Adornique.Services
{
    public class OrderService:IOrderService
    {
        public Task<IEnumerable<Order>> ListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Order> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(Order entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, Order entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
