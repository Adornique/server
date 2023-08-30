using Microsoft.EntityFrameworkCore;
using server.Adornique.Domain.Models;
using server.Adornique.Domain.Repositories;
using server.Shared.Persistence.Context;
using server.Shared.Persistence.Repository;

namespace server.Adornique.Persistence
{
    public class StatusOrderRepository : BaseRepository,IStatusOrderRepository
    {
        public StatusOrderRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<StatusOrder>> ListAsync()
        {
            return await _context.StatusOrders.ToListAsync();
        }

        public async Task<StatusOrder> FindByIdAsync(int id)
        {
            return await _context.StatusOrders.FindAsync(id);
        }

        public async Task AddAsync(StatusOrder entity)
        {
            await _context.StatusOrders.AddAsync(entity);
        }

        public void Update(StatusOrder entity)
        {
           _context.StatusOrders.Update(entity);
        }

        public void Delete(StatusOrder entity)
        {
            _context.StatusOrders.Remove(entity);
        }
    }
}
