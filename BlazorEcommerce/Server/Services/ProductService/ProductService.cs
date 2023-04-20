using BlazorEcommerce.Server.Data;
using BlazorEcommerce.Shared;
using BlazorEcommerce.Shared.Models;

namespace BlazorEcommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        public readonly DataContext _context;
        public ProductService(DataContext context) 
        {
            _context = context;
        }

        public async Task<ServiceResponse<Product>> AddProduct(Product product)
        {
            var response = new ServiceResponse<Product>();

            var result = await _context.Products.AddAsync(product);
            if (result == null)
            {
                response.Success = false;
                response.Message = "Could not add product.";
            }
            else
            {
                response.Data = result.Entity;
            }
            return response;
        }

        public async Task<ServiceResponse<Product>> GetProduct(int id)
        {
            var response = new ServiceResponse<Product>();
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                response.Success = false;
                response.Message = "This product does not exist.";
            }
            else
            {
                response.Data = product;
            }
            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductList()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.ToListAsync()
            };
            return response;
        }

        public async Task<ServiceResponse<Product>> DeleteProduct(Product product)
        {
            var response = new ServiceResponse<Product>();

            var result = await _context.Products.FindAsync(product.Id) == product;
            if (result == false)
            {
                response.Success = false;
                response.Message = "Product id not found.";
            }
            else
            {
                _context.Remove(product);
            }
            return response;
        }

        public Task<ServiceResponse<Product>> UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
