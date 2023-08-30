using Microsoft.AspNetCore.Mvc;
using server.Adornique.Domain.Models;
using server.Adornique.Domain.Repositories;

namespace server.Adornique.Domain.Repository
{
    public interface IUserRepository:ICrudRepository<User>
    {
        Task<User> FindByIdAsync(int id);
        Task<User> FindByEmailAsync(string email);
    }
}
