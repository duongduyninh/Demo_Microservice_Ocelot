using ProductAPI.Data.DTOs.ProductDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Repositories.Interfaces
{
    public interface IProductRepository
    {
        public Task<List<ProductInfo>> GetListProductAsync();
        public Task<ProductInfo> GetProductByIdAsync(int id);    
        public Task<bool> CheckProductIdValidAsync(int id);   
    }
}
