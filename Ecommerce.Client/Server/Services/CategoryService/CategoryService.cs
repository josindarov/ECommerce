using Ecommerce.Client.Server.Data;
using Ecommerce.Client.Shared;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Client.Server.Services.CategoryService;

public class CategoryService : ICategoryService
{
    private readonly DataContext _context;

    public CategoryService(DataContext context)
    {
        _context = context;
    }
    
    public async Task<ServiceResponse<List<Category>>> GetCategories()
    {
        var categories = await _context.Categories.ToListAsync();
        
        var result = new ServiceResponse<List<Category>>()
        {
            Data = categories
        };

        return result;
    }
}