using Bakery.Backend.Models;
using Bakery.Models;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Backend
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {
            
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ShopProductItem> ShopProductItems { get; set; }
    }
}
