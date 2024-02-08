using System.Net.Http.Json;
using Ecommerce.Client.Shared;

namespace Ecommerce.Client.Client.Services.ProductService;

public class ProductService : IProductService
{
    private readonly HttpClient _httpClient;

    public ProductService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public List<Product> Products { get; set; }
    
    public async Task GetProductsAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<
            ServiceResponse<List<Product>>>("api/Product");

        if (response != null && response.Data != null)
        {
            Products = response.Data;
        }
    }
}