using BlazorEcommerce.Shared;
using BlazorEcommerce.Shared.Models.Product;

namespace BlazorEcommerce.Server.Services.ProductService
{
    public interface IProductService
    {
        public Task<ServiceResponse<Product>> CreateProduct(Product product);
        public Task<ServiceResponse<Product>> RetrieveProduct(int id);
        public Task<ServiceResponse<List<Product>>> ListProducts();
        public Task<ServiceResponse<Product>> UpdateProduct(Product product);
        public Task<ServiceResponse<Product>> DeleteProduct(Product product);
    }
}
