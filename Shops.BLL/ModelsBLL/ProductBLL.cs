using Shops.BLL.NewFolder;

namespace Shops.BLL.ModelsBLL
{
    public class ProductBLL
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ShopId { get; set; }
        public ShopBLL Shop { get; set; }
    }
}
