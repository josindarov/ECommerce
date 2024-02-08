using Ecommerce.Client.Shared;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Client.Server.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    { }

    public DbSet<Product> Products { get; set; }
}