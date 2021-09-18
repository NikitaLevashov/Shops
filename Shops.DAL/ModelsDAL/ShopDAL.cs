using System.Collections.Generic;


namespace Shops.DAL.ModelsDAL
{
    public class ShopDAL
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string OperatingMode { get; set; }
        public IEnumerable<ProductDAL> Products { get; set; }
    }
}
