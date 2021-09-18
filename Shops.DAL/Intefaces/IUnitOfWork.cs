using Shops.DAL.ModelsDAL;
using System;

namespace Shops.DAL.Intefaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<ShopDAL> Shops { get; }
        IRepository<ProductDAL> Products { get; }
        void Save();
    }
}
