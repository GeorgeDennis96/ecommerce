using BlazorEcommerce.Shared.Models.Product.Admin;

namespace BlazorEcommerce.Client.Services.ProductService
{
    public interface IProductService
    {
        List<AdminProduct> AdminProducts { get; set; }
        List<Product> Products { get; set; }
        Task<bool> AdminGetProducts();

        Task AdminCreateProduct(AdminCreateProductRequest request);

        Task<Guid> AdminGetProductById(string id);

        Task AdminDeleteProduct(string id);

        Task<bool> GetProducts();
    }
}
