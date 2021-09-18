using Microsoft.EntityFrameworkCore;
using Shops.DAL.ModelsDAL;

namespace Shops.DAL.EFCore
{
    public class ShopContext : DbContext
    {
        public DbSet<ShopDAL> Shops { get; set; }
        public DbSet<ProductDAL> Products { get; set; }
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
            Database.EnsureCreated();          
        }
    }
}
