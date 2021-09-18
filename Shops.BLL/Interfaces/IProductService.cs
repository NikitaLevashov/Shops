using Shops.BLL.ModelsBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
