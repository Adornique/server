using Microsoft.AspNetCore.Mvc;
using server.Adornique.Domain.Models;

namespace server.Adornique.Domain.Services
{
    public interface IUserService : ICrudService<User>
    {
        Task<User> FindByEmailAsync(string email);
    }
}
