using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using server.Adornique.Domain.Models;
using server.Adornique.Domain.Services;
using server.Adornique.Resource.Create;
using server.Adornique.Resource.View;
using server.Shared.Extensions;

namespace server.Adornique.Controllers
{

    [ApiController]
    [Route("/api/v1/[controller]")]
    [Produces("application/json")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<UserResource>> GetAllAsync()
        {
            var result = await _userService.ListAsync();
            var resource = _mapper.Map<IEnumerable<User>, IEnumerable<UserResource>>(result);
            return resource;
        }

        [HttpGet("id/{id}")]
        public async Task<UserResource> GetByIdAsync(int id)
        {
            var result = await _userService.FindByIdAsync(id);
            var resource = _mapper.Map<User, UserResource>(result);
            return resource;
        }

        [HttpGet("email/{email}")]
        public async Task<UserResource> GetByEmailAsync(string email)
        {
            var result = await _userService.FindByEmailAsync(email);
            var resource = _mapper.Map<User, UserResource>(result);
            return resource;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveUserResource resource)
        {
            var model = _mapper.Map<SaveUserResource, User>(resource);
            await _userService.SaveAsync(model);            
            return Ok(new { message ="Registration successful"});
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] SaveUserResource resource)
        {
            var model = _mapper.Map<SaveUserResource, User>(resource);
            await _userService.UpdateAsync(id, model);
            return Ok(new { message = "Success" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _userService.DeleteAsync(id);
            return Ok();
        }
    }
}
