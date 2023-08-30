using server.Adornique.Domain.Models;
using server.Adornique.Domain.Repositories;
using server.Adornique.Domain.Services;
using server.Adornique.Persistence;
using server.Shared.Domain.Repository;

namespace server.Adornique.Services
{
    public class ProductService:IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _productRepository.ListAsync();
        }

        public async Task<Product> FindByIdAsync(int id)
        {
            return await _productRepository.FindByIdAsync(id);
        }

        public async Task SaveAsync(Product entity)
        {
            try
            {
                await _productRepository.AddAsync(entity);
                await _unitOfWork.CompleteAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateAsync(int id, Product entity)
        {
            var existing = await _productRepository.FindByIdAsync(id);

            if (existing == null)
            {
                throw new Exception($"This product don't exists");
            }

            existing.Name = entity.Name;
            existing.Description = entity.Description;
            existing.Price = entity.Price;
            existing.Quantity = entity.Quantity;
            existing.ImageUrl = entity.ImageUrl;


            try
            {
                _productRepository.Update(existing);
                await _unitOfWork.CompleteAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task DeleteAsync(int id)
        {
            var existing = await _productRepository.FindByIdAsync(id);

            if (existing == null)
                throw new Exception("Admin don't exist");

            try
            {
                _productRepository.Delete(existing);
                await _unitOfWork.CompleteAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
