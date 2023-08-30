using Microsoft.EntityFrameworkCore;
using server.Adornique.Domain.Models;
using server.Adornique.Domain.Repositories;
using server.Shared.Persistence.Context;
using server.Shared.Persistence.Repository;

namespace server.Adornique.Persistence
{
    public class PaymentRepository : BaseRepository,IPaymentRepository
    {
        public PaymentRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Payment>> ListAsync()
        {
            return await _context.Payments.ToListAsync();
        }

        public async Task<Payment> FindByIdAsync(int id)
        {
            return await _context.Payments.FindAsync(id);
        }

        public async Task AddAsync(Payment entity)
        {
            await _context.Payments.AddAsync(entity);
        }

        public void Update(Payment entity)
        {
            _context.Payments.Update(entity);
        }

        public void Delete(Payment entity)
        {
            _context.Payments.Remove(entity);
        }
    }
}
