using BlazorEcommerce.Shared.Models.Product.Admin;

namespace BlazorEcommerce.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient http)
        {
            _httpClient = http;
        }

        public List<AdminProduct> AdminProducts { get; set; }

        public List<Product> Products { get; set; }

        public Task AdminCreateProduct(AdminCreateProductRequest request)
        {
            throw new NotImplementedException();
        }

        public Task AdminDeleteProduct(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> AdminGetProductById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> AdminGetProducts()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<AdminProduct>>>("api/product");
            if (result != null && result.Data != null)
            {
                AdminProducts = result.Data;
                return true;
            }
            return false;
        }

        public async Task<bool> GetProducts()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");
            if (result != null && result.Data != null)
            {
                var prods = new List<Product>();

                foreach (var item in result.Data)
                {
                    prods.Add(new Product()
                    {
                        Id = item.Id,
                        Title = item.Title,
                        Description = item.Description,
                        ImageUrl = item.ImageUrl,
                        Price = item.Price,
                    });
                }

                Products = prods;
                return true;
            }
            return false;
        }

    }
}
