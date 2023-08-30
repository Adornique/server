using server.Adornique.Domain.Models;
using server.Adornique.Domain.Repositories;
using server.Adornique.Domain.Services;
using server.Shared.Domain.Repository;

namespace server.Adornique.Services
{
    public class CustomerService:ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CustomerService(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
        {
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Customer>> ListAsync()
        {
            return await _customerRepository.ListAsync();
        }

        public async Task<Customer> FindByIdAsync(int id)
        {
            return await _customerRepository.FindByIdAsync(id);
        }

        public async Task SaveAsync(Customer entity)
        {
            try
            {
                await _customerRepository.AddAsync(entity);
                await _unitOfWork.CompleteAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateAsync(int id, Customer entity)
        {
            var existing = await _customerRepository.FindByIdAsync(id);

            if (existing == null)
            {
                throw new Exception($"This customer don't exist");
            }

            existing.UserId = entity.UserId;

            try
            {
                await _customerRepository.AddAsync(existing);
                await _unitOfWork.CompleteAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async Task DeleteAsync(int id)
        {
            var existing = await _customerRepository.FindByIdAsync(id);

            if (existing == null)
                throw new Exception("Customer don't exist");

            try
            {
                _customerRepository.Delete(existing);
                await _unitOfWork.CompleteAsync();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
