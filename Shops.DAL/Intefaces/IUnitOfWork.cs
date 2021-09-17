using Shops.DAL.ModelsDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.DAL.Intefaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<ShopDAL> Shops { get; }
        IRepository<ProductDAL> Products { get; }
        void Save();
    }
}
