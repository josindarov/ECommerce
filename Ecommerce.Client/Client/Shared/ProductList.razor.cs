using Ecommerce.Client.Client.Services.ProductService;
using Ecommerce.Client.Shared;
using Microsoft.AspNetCore.Components;

namespace Ecommerce.Client.Client.Shared;

public partial class ProductList
{
    [Inject]
    public IProductService ProductService { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await ProductService.GetProductsAsync();
    }
}