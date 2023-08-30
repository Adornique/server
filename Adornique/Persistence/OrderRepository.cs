using Microsoft.EntityFrameworkCore;
using server.Adornique.Domain.Models;
using server.Adornique.Domain.Repositories;
using server.Shared.Persistence.Context;
using server.Shared.Persistence.Repository;

namespace server.Adornique.Persistence
{
    public class OrderRepository : BaseRepository,IOrderRepository
    {
        public OrderRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Order>> ListAsync()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<Order> FindByIdAsync(int id)
        {
            return await _context.Orders.FindAsync(id);
        }

        public async Task AddAsync(Order entity)
        {
            await _context.Orders.AddAsync(entity);
        }

        public void Update(Order entity)
        {
            _context.Orders.Update(entity);
        }

        public void Delete(Order entity)
        {
            _context.Orders.Remove(entity);
        }

    }
}
