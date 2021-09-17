using Shops.BLL.Interfaces;
using Shops.BLL.Mapping;
using Shops.BLL.ModelsBLL;
using Shops.BLL.NewFolder;
using Shops.DAL.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.BLL.Service
{
    public class ProductService /*: IShopService*/
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        //public void Create(ProductBLL item)
        //{
        //    _unitOfWork.Products
        //    throw new NotImplementedException();
        //}

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ProductBLL Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductBLL> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(ProductBLL item)
        {
            throw new NotImplementedException();
        }

        //IEnumerable<ShopBLL> IShopService.GetAll()
        //{
        //    _unitOfWork.Shops.GetAll().MapToEnumerableBLLShop();

        //}
    }
}
