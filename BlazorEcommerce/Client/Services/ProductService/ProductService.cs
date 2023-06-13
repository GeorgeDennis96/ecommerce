using BlazorEcommerce.Shared.Models.Product;

namespace BlazorEcommerce.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient http)
        {
            _httpClient = http;
        }

        public List<Product> Products { get; set; }

        public Task AdminCreateProduct(CreateProductRequest request)
        {
            throw new NotImplementedException();
        }

        public Task AdminDeleteProduct(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> AdminGetProducts()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");
            if (result != null && result.Data != null)
            {
                Products = result.Data;
                return true;
            }
            return false;
        }

    }
}
