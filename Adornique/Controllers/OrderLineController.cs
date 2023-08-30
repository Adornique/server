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
    public class OrderLineController:ControllerBase
    {
        private readonly IOrderLineService _orderLineService;
        private readonly IMapper _mapper;

        public OrderLineController(IOrderLineService orderLineService, IMapper mapper)
        {
            _orderLineService = orderLineService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<OrderLineResource>> GetAllAsync()
        {
            var result = await _orderLineService.ListAsync();
            var resource = _mapper.Map<IEnumerable<OrderLine>, IEnumerable<OrderLineResource>>(result);
            return resource;
        }


        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveOrderLineResource resource)
        {
            var model = _mapper.Map<SaveOrderLineResource, OrderLine>(resource);
            await _orderLineService.SaveAsync(model);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] SaveOrderLineResource resource)
        {
            var model = _mapper.Map<SaveOrderLineResource, OrderLine>(resource);
            await _orderLineService.UpdateAsync(id, model);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _orderLineService.DeleteAsync(id);
            return Ok();
        }
    }
}
