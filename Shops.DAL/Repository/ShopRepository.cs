using Microsoft.EntityFrameworkCore;
using Shops.DAL.EFCore;
using Shops.DAL.Intefaces;
using Shops.DAL.ModelsDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.DAL.Repository
{
    public class ShopRepository : IRepository<ShopDAL>
    {
        private readonly ShopContext _context;
        public ShopRepository(ShopContext context)
        {
            _context = context;
        }

        public void Create(ShopDAL item)
        {
            _context.Add(item);
        }

        public void Delete(int id)
        {
            ShopDAL shop = _context.Shops.Find(id);
            if (shop != null)
               _context.Shops.Remove(shop);
        }

        public ShopDAL Get(int id)
        {
            return _context.Shops.Find(id);
        }

        public IEnumerable<ShopDAL> GetAll()
        {
            return _context.Shops.Include(x=>x.Products);
        }

        public void Update(ShopDAL item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
