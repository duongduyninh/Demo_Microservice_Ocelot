using Microsoft.EntityFrameworkCore;
using ProductAPI.Data;
using ProductAPI.Data.DTOs.ProductDTO;
using ProductAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Repositories.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly Dbcontext_Product _context;

        public ProductRepository(Dbcontext_Product context)
        {
            _context = context;
        }

        public async Task<List<ProductInfo>> GetListProductAsync()
        {
            var getListProduct = await (from p in _context.Products
                                        select new ProductInfo
                                        {
                                            ProductId = p.Id,
                                            ProductName = p.ProductName,
                                            Description = p.Description,    
                                        }).ToListAsync();
            if(getListProduct == null ) { return null; }
            return getListProduct;
        }

        public async Task<ProductInfo> GetProductByIdAsync(int id)
        {
            var getProductById = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);  
            if( getProductById != null ) 
            {
                var product = new ProductInfo
                {
                    ProductId = getProductById.Id,
                    ProductName = getProductById.ProductName,
                    Description = getProductById.Description,
                }; 
                return product; 
            } return null;
        }

        public async Task<bool> CheckProductIdValidAsync(int id)
        {
            return await _context.Products.AnyAsync(p => p.Id == id); 
        }
    }
}
