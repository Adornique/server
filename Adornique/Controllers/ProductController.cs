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
    public class ProductController:Controller
    {
        private readonly IProductService _ProductService;
        private readonly IMapper _mapper;

        public ProductController(IProductService ProductService, IMapper mapper)
        {
            _ProductService = ProductService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductResource>> GetAllAsync()
        {
            var result = await _ProductService.ListAsync();
            var resource = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductResource>>(result);
            return resource;
        }


        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveProductResource resource)
        {
            var model = _mapper.Map<SaveProductResource, Product>(resource);
            await _ProductService.SaveAsync(model);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] SaveProductResource resource)
        {
            var model = _mapper.Map<SaveProductResource, Product>(resource);
            await _ProductService.UpdateAsync(id, model);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _ProductService.DeleteAsync(id);
            return Ok();
        }
    }
}
