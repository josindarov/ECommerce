using Ecommerce.Client.Shared;

namespace Ecommerce.Client.Server.Services.ProductService;

public interface IProductService
{
    Task<ServiceResponse<List<Product>>> GetProductsAsync();
    Task<ServiceResponse<Product>> GetProductByIdAsync(int id);
}