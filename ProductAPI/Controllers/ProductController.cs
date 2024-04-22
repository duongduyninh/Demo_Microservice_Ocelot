using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Services.Services;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController( IProductService productService )
        {
            _productService = productService;
        }

        [HttpGet("/{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            try
            {
                var result = await _productService.GetProductById(id);
                if (result == null) { return BadRequest(result); }

                return Ok(result);

            }catch { return StatusCode(500); }
        }

        [HttpGet]
        public async Task<IActionResult> GetListProduct()
        {
            try
            {
                var result = await _productService.GetListProduct();
                if (result == null) { return BadRequest(result); }

                return Ok(result);

            }
            catch { return StatusCode(500); }
        }
    }
}
