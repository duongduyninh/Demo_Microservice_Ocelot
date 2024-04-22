using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Data.DTOs.ProductDTO
{
    public class GetListProductResponse
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public List<ProductInfo> ProductInfos { get; set; }
    }
}
