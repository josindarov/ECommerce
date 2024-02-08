using Ecommerce.Client.Shared;

namespace Ecommerce.Client.Server.Services.ProductService;

public interface IProductService
{
    public Task<ServiceResponse<List<Product>>> GetProductsAsync();
}