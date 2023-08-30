using Microsoft.EntityFrameworkCore;
using server.Adornique.Domain.Models;
using server.Adornique.Domain.Repositories;
using server.Shared.Persistence.Context;
using server.Shared.Persistence.Repository;

namespace server.Adornique.Persistence
{
    public class CosmeticRepository:BaseRepository,ICosmeticRepository
    {
        public CosmeticRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Cosmetic>> ListAsync()
        {
            return await _context.Cosmetics.ToListAsync();
        }

        public async Task<Cosmetic> FindByIdAsync(int id)
        {
            return await _context.Cosmetics.FindAsync(id);
        }

        public async Task AddAsync(Cosmetic entity)
        {
            await _context.Cosmetics.AddAsync(entity);
        }

        public void Update(Cosmetic entity)
        {
            _context.Cosmetics.Update(entity);
        }

        public void Delete(Cosmetic entity)
        {
            _context.Cosmetics.Remove(entity);
        }
    }
}
