using Shops.BLL.ModelsBLL;
using System.Collections.Generic;

namespace Shops.BLL.NewFolder
{
    public class ShopBLL
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string OperatingMode { get; set; }
        public IEnumerable<ProductBLL> Products { get; set; }
    }
}
