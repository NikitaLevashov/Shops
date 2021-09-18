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
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(ProductBLL item)
        {
            _unitOfWork.Products.Create(item.MapToDALProduct());
            _unitOfWork.Save();
        }

        public void Delete(int id)
        {
            _unitOfWork.Products.Delete(id);
            _unitOfWork.Save();
        }

        public ProductBLL Get(int id)
        {
            return _unitOfWork.Products.Get(id).MapToBLLProduct();
        }

        public IEnumerable<ProductBLL> GetAll()
        {
            return _unitOfWork.Products.GetAll().MapToEnumerableBLLProduct();
        }

        public void Update(ProductBLL item)
        {
            _unitOfWork.Products.Update(item.MapToDALProduct());
            _unitOfWork.Save();
        }
    }
}
