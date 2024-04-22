using ProductAPI.Data.DTOs.ProductDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Services.Services
{
    public interface IProductService
    {
        public Task<GetListProductResponse> GetListProduct();
        public Task<GetProductResponse> GetProductById(int id);
    }
}
