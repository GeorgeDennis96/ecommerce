using BlazorEcommerce.Shared;

namespace BlazorEcommerce.Server.Services.ProductService
{
    public interface IProductService
    {

        public Task<ServiceResponse<Product>> AddProduct(Product product);
        public Task<ServiceResponse<Product>> GetProduct(int id);
        public Task<ServiceResponse<List<Product>>> GetProductList();
        public Task<ServiceResponse<Product>> UpdateProduct(Product product);
        public Task<ServiceResponse<Product>> DeleteProduct(Product product);

    }
}
