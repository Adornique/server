using server.Adornique.Domain.Models;
using server.Adornique.Domain.Services;

namespace server.Adornique.Services
{
    public class PaymentService:IPaymentService
    {
        public Task<IEnumerable<Payment>> ListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Payment> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(Payment entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, Payment entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
