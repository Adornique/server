using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using server.Adornique.Domain.Models;
using server.Adornique.Domain.Services;
using server.Adornique.Resource.Create;
using server.Adornique.Resource.View;
using server.Adornique.Services;
using server.Shared.Extensions;

namespace server.Adornique.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    [Produces("application/json")]
    public class AdminController: ControllerBase
    {
        private readonly IAdminService _adminService;
        private readonly IMapper _mapper;

        public AdminController(IAdminService adminService, IMapper mapper)
        {
            _adminService = adminService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<AdminResource>> GetAllAsync()
        {
            var result = await _adminService.ListAsync();
            var resource = _mapper.Map<IEnumerable<Admin>, IEnumerable<AdminResource>>(result);
            return resource;
        }


        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveAdminResource resource)
        {

            var model = _mapper.Map<SaveAdminResource, Admin>(resource);
            await _adminService.SaveAsync(model);       
            return Ok();
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] SaveAdminResource resource)
        {
     
            var model = _mapper.Map<SaveAdminResource, Admin>(resource);
            await _adminService.UpdateAsync(id, model);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _adminService.DeleteAsync(id);
            return Ok();
        }
    }
}
