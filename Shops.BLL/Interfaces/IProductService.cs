using Shops.BLL.ModelsBLL;
using System.Collections.Generic;

namespace Shops.BLL.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductBLL> GetAll();
        ProductBLL Get(int id);
        void Create(ProductBLL item);
        void Update(ProductBLL item);
        void Delete(int id);
    }
}
