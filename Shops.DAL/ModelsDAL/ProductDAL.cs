namespace Shops.DAL.ModelsDAL
{
    public class ProductDAL
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ShopId { get; set; }
        public ShopDAL Shop { get; set; }
    }
}
