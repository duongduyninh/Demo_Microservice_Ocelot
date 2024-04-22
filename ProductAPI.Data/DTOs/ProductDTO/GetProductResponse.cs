using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Data.DTOs.ProductDTO
{
    public class GetProductResponse
    {
        public bool Status { get; set; }    
        public string Message { get; set; }
        public ProductInfo ProductInfo { get; set; }
    }
}
