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
    public class CustomerController:ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerResource>> GetAllAsync()
        {
            var result = await _customerService.ListAsync();
            var resource = _mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerResource>>(result);
            return resource;
        }


        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveCustomerResource resource)
        {

            var model = _mapper.Map<SaveCustomerResource, Customer>(resource);
            await _customerService.SaveAsync(model);
            return Ok();
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] SaveCustomerResource resource)
        {
            var model = _mapper.Map<SaveCustomerResource, Customer>(resource);
            await _customerService.UpdateAsync(id, model);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _customerService.DeleteAsync(id);
            return Ok();
        }
    }
}
