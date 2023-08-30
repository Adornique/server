using server.Adornique.Domain.Models;
using server.Adornique.Domain.Repositories;
using server.Adornique.Domain.Services;
using server.Shared.Domain.Repository;

namespace server.Adornique.Services
{
    public class AdminService:IAdminService
    {

        private readonly IAdminRepository _adminRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AdminService(IAdminRepository adminRepository, IUnitOfWork unitOfWork)
        {
            _adminRepository = adminRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Admin>> ListAsync()
        {
            return await _adminRepository.ListAsync();
        }
        public async Task<Admin> FindByIdAsync(int id)
        {
            return await _adminRepository.FindByIdAsync(id);
        }

        public async Task SaveAsync(Admin entity)
        {
            try
            {
                await _adminRepository.AddAsync(entity);
                await _unitOfWork.CompleteAsync();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateAsync(int id, Admin entity)
        {
            var existing = await _adminRepository.FindByIdAsync(id);

            if (existing == null)
            {
                throw new Exception("This admin don't exist");
            }

            existing.UserId = entity.UserId;

            try
            {
                _adminRepository.Update(existing);
                await _unitOfWork.CompleteAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task DeleteAsync(int id)
        {
            var existing = await _adminRepository.FindByIdAsync(id);

            if (existing == null)
                throw new Exception("This admin don't exist");

            try { 
                _adminRepository.Delete(existing);
                await _unitOfWork.CompleteAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
