using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using server.Adornique.Domain.Models;
using server.Adornique.Domain.Repository;
using server.Adornique.Domain.Services;
using server.Adornique.Resource.View;
using server.Shared.Domain.Repository;
using server.Shared.Persistence.Context;
using server.Shared.Persistence.Repository;

namespace server.Adornique.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<User>> ListAsync()
        {
            return await _userRepository.ListAsync();
        }

        public async Task<User> FindByIdAsync(int id)
        {
            return await _userRepository.FindByIdAsync(id);
        }

        public async Task<User> FindByEmailAsync(string email)
        {
            return await _userRepository.FindByEmailAsync(email);
        }

        public async Task SaveAsync(User entity)
        {
            try
            {
                await _userRepository.AddAsync(entity);
                await _unitOfWork.CompleteAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateAsync(int id, User entity)
        {
            var existing = await _userRepository.FindByIdAsync(id);

            if(existing == null)
            {
                throw new Exception($"{nameof(User)} already exists");
            }

            existing.Name = entity.Name;
            existing.LastName = entity.LastName;
            existing.NickName = entity.NickName;
            existing.Email = entity.Email;
            existing.Phone = entity.Phone;
            existing.Password = entity.Password;

            try
            {
                _userRepository.Update(existing);
                await _unitOfWork.CompleteAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task DeleteAsync(int id)
        {
            var existing = await _userRepository.FindByIdAsync(id);

            if (existing == null)
                throw new Exception("User don't exist");

            try
            {
                _userRepository.Delete(existing);
                await _unitOfWork.CompleteAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
