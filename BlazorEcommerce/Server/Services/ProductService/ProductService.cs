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

        public Task<ServiceResponse<Product>> AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Product>> DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Product>> GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<Product>>> GetProductList()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.ToListAsync()
            };
            return response;
        }

        public Task<ServiceResponse<Product>> UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
