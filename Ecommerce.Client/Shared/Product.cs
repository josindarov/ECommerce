using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Client.Shared;

public class Product
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? ImageUrl { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }

    public Category? Category { get; set; }

    public int CategoryId { get; set; }
}