using CqrsSample.Api.Entities;
using Microsoft.EntityFrameworkCore;
namespace CqrsSample.Api;

public class ProdcutDbContext:DbContext
{
    public ProdcutDbContext(DbContextOptions<ProdcutDbContext> options):base(options)
    {
    }
    public DbSet<Product> Products { get; set; }
}
