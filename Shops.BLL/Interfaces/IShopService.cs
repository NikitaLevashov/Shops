using Shops.BLL.NewFolder;
using System.Collections.Generic;

namespace Shops.BLL.Interfaces
{
    public interface IShopService
    {
        IEnumerable<ShopBLL> GetAll();
        ShopBLL Get(int id);
        void Create(ShopBLL item);
        void Update(ShopBLL item);
        void Delete(int id);
    }
}
