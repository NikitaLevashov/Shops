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
    public class ProductRepository : IRepository<ProductDAL>
    {
        private readonly ShopContext _context;
        public ProductRepository(ShopContext context)
        {
            _context = context;
        }
        public void Create(ProductDAL item)
        {
            _context.Products.Add(item);
        }

        public void Delete(int id)
        {
            ProductDAL product = _context.Products.Find(id);
            if (product != null)
                _context.Products.Remove(product);
        }

        public ProductDAL Get(int id)
        {
            return _context.Products.Find(id);
        }

        public IEnumerable<ProductDAL> GetAll()
        {
            return _context.Products;
        }

        public void Update(ProductDAL item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
