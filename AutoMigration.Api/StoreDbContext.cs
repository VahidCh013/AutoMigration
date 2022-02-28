using AutoMigration.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AutoMigration.Api;

public class StoreDbContext:DbContext
{
    private DbSet<Product> Products { get; set; }
    public StoreDbContext(DbContextOptions<StoreDbContext> options):base(options)
    {
        
    }
}