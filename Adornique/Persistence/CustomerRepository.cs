using Microsoft.EntityFrameworkCore;
using server.Adornique.Domain.Models;
using server.Adornique.Domain.Repositories;
using server.Shared.Persistence.Context;
using server.Shared.Persistence.Repository;

namespace server.Adornique.Persistence
{
    public class CustomerRepository:BaseRepository,ICustomerRepository
    {
        public CustomerRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Customer>> ListAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> FindByIdAsync(int id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public async Task AddAsync(Customer entity)
        {
            await _context.Customers.AddAsync(entity);
        }

        public void Update(Customer entity)
        {
            _context.Customers.Update(entity);
        }

        public void Delete(Customer entity)
        {
           _context.Customers.Remove(entity);
        }
    }
}
