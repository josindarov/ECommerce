using Ecommerce.Client.Shared;

namespace Ecommerce.Client.Server.Services.CategoryService;

public interface ICategoryService
{
    Task<ServiceResponse<List<Category>>> GetCategories();
}