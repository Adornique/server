using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
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
    public class CosmeticController:ControllerBase
    {
        private readonly ICosmeticService _cosmeticService;
        private readonly IMapper _mapper;

        public CosmeticController(ICosmeticService cosmeticService, IMapper mapper)
        {
            _cosmeticService = cosmeticService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<CosmeticResource>> GetAllAsync()
        {
            var result = await _cosmeticService.ListAsync();
            var resource = _mapper.Map<IEnumerable<Cosmetic>, IEnumerable<CosmeticResource>>(result);
            return resource;
        }


        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveCosmeticResource resource)
        {
 
            var model = _mapper.Map<SaveCosmeticResource, Cosmetic>(resource);
            await _cosmeticService.SaveAsync(model);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] SaveCosmeticResource resource)
        {
            var model = _mapper.Map<SaveCosmeticResource, Cosmetic>(resource);
            await _cosmeticService.UpdateAsync(id, model);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _cosmeticService.DeleteAsync(id);
            return Ok();
        }
    }
}
