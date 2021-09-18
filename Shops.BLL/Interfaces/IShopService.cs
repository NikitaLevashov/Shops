﻿using Shops.BLL.ModelsBLL;
using Shops.BLL.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
