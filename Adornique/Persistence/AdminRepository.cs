using Microsoft.EntityFrameworkCore;
using server.Adornique.Domain.Models;
using server.Adornique.Domain.Repositories;
using server.Shared.Persistence.Context;
using server.Shared.Persistence.Repository;

namespace server.Adornique.Persistence
{
    public class AdminRepository: BaseRepository, IAdminRepository
    {
        public AdminRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Admin>> ListAsync()
        {
            return await _context.Admins.ToListAsync();
        }

        public async Task<Admin> FindByIdAsync(int id)
        {
            return await _context.Admins.FindAsync(id);
        }

        public async Task AddAsync(Admin entity)
        {
            await _context.Admins.AddAsync(entity);
        }

        public void Update(Admin entity)
        {
            _context.Admins.Update(entity);
        }

        public void Delete(Admin entity)
        {
            _context.Admins.Remove(entity);
        }
    }
}
