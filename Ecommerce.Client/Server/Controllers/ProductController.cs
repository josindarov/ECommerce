using Ecommerce.Client.Server.Services.ProductService;
using Ecommerce.Client.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Client.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductsAsync()
    {
        var result = await _productService.GetProductsAsync();
        return Ok(result);  
    }
}