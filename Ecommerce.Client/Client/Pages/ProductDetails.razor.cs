using Ecommerce.Client.Client.Services.ProductService;
using Ecommerce.Client.Shared;
using Microsoft.AspNetCore.Components;

namespace Ecommerce.Client.Client.Pages;

public partial class ProductDetails
{
    [Inject]
    public IProductService ProductService { get; set; }
    
    [Parameter] 
    public int Id { get; set; }

    private Product? product;
    
    private string _message = String.Empty;

    protected override async Task OnParametersSetAsync()
    {
        _message = "Loading product ...";

        var result = await ProductService.GetProductAsync(Id);
        if (!result.Success)
        {
            _message = result.Message;
        }
        else
        {
            product = result.Data;
        }
    }
}