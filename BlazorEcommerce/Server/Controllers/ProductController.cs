using BlazorEcommerce.Server.Data;
using BlazorEcommerce.Server.Services.ProductService;
using BlazorEcommerce.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly IProductService ProductService;

        public ProductController(IProductService productService)
        {
            ProductService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProduct()
        {
            var result = await ProductService.GetProductList();
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<Product>>> DeleteProduct(Product product)
        {
            var result = await ProductService.DeleteProduct(product);

            return Ok(result);
        }
    }
}
