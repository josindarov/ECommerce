using Ecommerce.Client.Shared;

namespace Ecommerce.Client.Client.Services.CategoryService;

public interface ICategoryService
{
    List<Category> Categories { get; set; }
    Task GetCategories();
}