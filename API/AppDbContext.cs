using Microsoft.EntityFrameworkCore;
using Models;

namespace API;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Product {  get; set; }
}
