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

        public void Create(ShopBLL item)
        {
            _unitOfWork.Shops.Create(item.MapToDALShop());
        }

        public void Delete(int id)
        {
            _unitOfWork.Shops.Delete(id);
        }

        public ShopBLL Get(int id)
        {
            return _unitOfWork.Shops.Get(id).MapToBLLShop();
        }

        public IEnumerable<ShopBLL> GetAll()
        {
           return _unitOfWork.Shops.GetAll().MapToEnumerableBLLShop();
        }

        public void Update(ShopBLL item)
        {
            _unitOfWork.Shops.Update(item.MapToDALShop());
        }
    }
}
