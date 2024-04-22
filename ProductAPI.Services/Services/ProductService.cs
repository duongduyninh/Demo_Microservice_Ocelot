using ProductAPI.Data.DTOs.ProductDTO;
using ProductAPI.Repositories.Interfaces;
using ProductAPI.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository) 
        {
            _productRepository = productRepository;
        } 
        public async Task<GetListProductResponse> GetListProduct()
        {
            var result = await _productRepository.GetListProductAsync();
            if (result == null) { return null; }

            return new GetListProductResponse
            {
                Status = true,
                Message = "Get list product success",
                ProductInfos = result
            };
        }

        public async Task<GetProductResponse> GetProductById(int id)
        {
            var checkProductIdValid = await _productRepository.CheckProductIdValidAsync(id);
            if (checkProductIdValid == false) { return null; }

            var result = await _productRepository.GetProductByIdAsync(id);
            if (result == null) { return null; }

            return new GetProductResponse
            {
                Status = true,
                Message = "Get product success",
                ProductInfo = result
            };
        }
    }
}
