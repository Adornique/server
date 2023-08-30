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
    public class StatusOrderController : ControllerBase
    {
        private readonly IStatusOrderService _statusOrderService;
        private readonly IMapper _mapper;

        public StatusOrderController(IStatusOrderService statusOrderService, IMapper mapper)
        {
            _statusOrderService = statusOrderService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<StatusOrderResource>> GetAllAsync()
        {
            var result = await _statusOrderService.ListAsync();
            var resource = _mapper.Map<IEnumerable<StatusOrder>, IEnumerable<StatusOrderResource>>(result);
            return resource;
        }


        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveStatusOrderResource resource)
        {
            var model = _mapper.Map<SaveStatusOrderResource, StatusOrder>(resource);
            await _statusOrderService.SaveAsync(model);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] SaveStatusOrderResource resource)
        {
            var model = _mapper.Map<SaveStatusOrderResource, StatusOrder>(resource);
            await _statusOrderService.UpdateAsync(id, model);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _statusOrderService.DeleteAsync(id);
            return Ok();
        }
    }
}
