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
    public class JewelryController:ControllerBase
    {
        private readonly IJewelryService _jewelryService;
        private readonly IMapper _mapper;

        public JewelryController(IJewelryService jewelryService, IMapper mapper)
        {
            _jewelryService = jewelryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<JewelryResource>> GetAllAsync()
        {
            var result = await _jewelryService.ListAsync();
            var resource = _mapper.Map<IEnumerable<Jewelry>, IEnumerable<JewelryResource>>(result);
            return resource;
        }


        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveJewelryResource resource)
        {
            var model = _mapper.Map<SaveJewelryResource, Jewelry>(resource);
            await _jewelryService.SaveAsync(model);

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] SaveJewelryResource resource)
        {
            var model = _mapper.Map<SaveJewelryResource, Jewelry>(resource);
            await _jewelryService.UpdateAsync(id, model);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _jewelryService.DeleteAsync(id);
            return Ok();
        }
    }
}
