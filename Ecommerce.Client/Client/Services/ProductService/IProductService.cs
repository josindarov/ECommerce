using Ecommerce.Client.Shared;

namespace Ecommerce.Client.Client.Services.ProductService;

public interface IProductService
{
    List<Product> Products { get; set; }

    Task GetProductsAsync();

    Task<ServiceResponse<Product>> GetProductAsync(int productId);
}