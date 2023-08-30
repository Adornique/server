using Microsoft.EntityFrameworkCore;
using server.Adornique.Domain.Models;
using server.Adornique.Domain.Repositories;
using server.Shared.Persistence.Context;
using server.Shared.Persistence.Repository;

namespace server.Adornique.Persistence
{
    public class JewelryRepository : BaseRepository,IJewelryRepository
    {
        public JewelryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Jewelry>> ListAsync()
        {
            return await _context.Jewelries.ToListAsync();
        }
        public async Task<Jewelry> FindByIdAsync(int id)
        {
            return await _context.Jewelries.FindAsync(id);
        }

        public async Task AddAsync(Jewelry entity)
        {
           await _context.Jewelries.AddAsync(entity);
        }

        public void Update(Jewelry entity)
        {
            _context.Jewelries.Update(entity);
        }

        public void Delete(Jewelry entity)
        {
           _context.Jewelries.Remove(entity);
        }
    }
}
