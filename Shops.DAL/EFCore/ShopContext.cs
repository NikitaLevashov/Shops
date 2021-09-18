using Microsoft.EntityFrameworkCore;
using Shops.DAL.ModelsDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
