using Microsoft.EntityFrameworkCore;
using server.Adornique.Domain.Models;
using server.Adornique.Domain.Repositories;
using server.Shared.Persistence.Context;
using server.Shared.Persistence.Repository;

namespace server.Adornique.Persistence
{
    public class OrderLineRepository:BaseRepository,IOrderLineRepository
    {
        public OrderLineRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<OrderLine>> ListAsync()
        {
            return await _context.OrderLines.ToListAsync();
        }

        public async Task<OrderLine> FindByIdAsync(int id)
        {
            return await _context.OrderLines.FindAsync(id);
        }

        public async Task AddAsync(OrderLine entity)
        {
            await _context.OrderLines.AddAsync(entity);
        }

        public void Update(OrderLine entity)
        {
            _context.OrderLines.Update(entity);
        }

        public void Delete(OrderLine entity)
        {
           _context.OrderLines.Remove(entity);
        }
    }
}
