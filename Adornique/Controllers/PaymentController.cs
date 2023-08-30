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
    public class PaymentController:ControllerBase
    {
        private readonly IPaymentService _paymentService;
        private readonly IMapper _mapper;

        public PaymentController(IPaymentService paymentService, IMapper mapper)
        {
            _paymentService = paymentService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<PaymentResource>> GetAllAsync()
        {
            var result = await _paymentService.ListAsync();
            var resource = _mapper.Map<IEnumerable<Payment>, IEnumerable<PaymentResource>>(result);
            return resource;
        }


        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SavePaymentResource resource)
        {
            var model = _mapper.Map<SavePaymentResource, Payment>(resource);
            await _paymentService.SaveAsync(model);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] SavePaymentResource resource)
        {
            var model = _mapper.Map<SavePaymentResource, Payment>(resource);
            await _paymentService.UpdateAsync(id, model);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _paymentService.DeleteAsync(id);
            return Ok();
        }
    }
}
