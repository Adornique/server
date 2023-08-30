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
    public class OrderController:ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrderController(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<OrderResource>> GetAllAsync()
        {
            var result = await _orderService.ListAsync();
            var resource = _mapper.Map<IEnumerable<Order>, IEnumerable<OrderResource>>(result);
            return resource;
        }


        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveOrderResource resource)
        {
            var model = _mapper.Map<SaveOrderResource, Order>(resource);
            await _orderService.SaveAsync(model);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] SaveOrderResource resource)
        {
            var model = _mapper.Map<SaveOrderResource, Order>(resource);
            await _orderService.UpdateAsync(id, model);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _orderService.DeleteAsync(id);
            return Ok();
        }
    }
}
