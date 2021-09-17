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
    public class ShopService : IShopService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ShopService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Create(ProductBLL item)
        {            
        }
        public void Delete(int id)
        {
            
        }

        public ProductBLL Get(int id)
        {
            throw new Exception();
        }

        public IEnumerable<ShopBLL> GetAll()
        {
            return _unitOfWork.Shops.GetAll().MapToEnumerableBLLShop();
        }

        //public void Update(ProductBLL item)
        //{
        //    _unitOfWork.Shops.Update(item);
        //}
    }
}
