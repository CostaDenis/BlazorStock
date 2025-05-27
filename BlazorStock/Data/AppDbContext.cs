using BlazorStock.Components;
using BlazorStock.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorStock.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

    }
}