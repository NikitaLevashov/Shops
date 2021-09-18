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
    public class EFUnitOfWork : IUnitOfWork
    {
        private ShopContext _context;
        private ShopRepository shopRepository;
        private ProductRepository productRepository;
        public EFUnitOfWork(ShopContext context)
        {
            _context = context;
        }
        public IRepository<ShopDAL> Shops
        {
            get
            {
                if (shopRepository == null)
                    shopRepository = new ShopRepository(_context);
                return shopRepository;
            }
        }

        public IRepository<ProductDAL> Products
        {
            get
            {
                if (productRepository == null)
                    productRepository = new ProductRepository(_context);
                return productRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
