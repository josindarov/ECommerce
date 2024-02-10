using Ecommerce.Client.Server.Data;
using Ecommerce.Client.Shared;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Client.Server.Services.ProductService;

public class ProductService : IProductService
{
    private readonly DataContext _context;

    public ProductService(DataContext context)
    {
        _context = context;
    }
    public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
    {
        var response = new ServiceResponse<List<Product>>()
        {
            Data = await _context.Products.ToListAsync()
        };

        return response;
    }

    public async Task<ServiceResponse<Product>> GetProductByIdAsync(int id)
    {
        var response = new ServiceResponse<Product>();
        var product = await _context.Products.FindAsync(id);
        
        if (product == null)
        {
            response.Success = false;
            response.Message = "Sorry, there is no product in this address";
        }
        else
        {
            response.Data = product;
        }

        return response;
    }
}