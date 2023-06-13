using BlazorEcommerce.Shared.Models.Product;

namespace BlazorEcommerce.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        Task<bool> AdminGetProducts();

        Task AdminCreateProduct(CreateProductRequest request);

        Task AdminDeleteProduct(string id);
    }
}
