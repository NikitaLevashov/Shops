using AutoMapper;
using Shops.BLL.ModelsBLL;
using Shops.BLL.NewFolder;
using Shops.DAL.ModelsDAL;
using System.Collections.Generic;


namespace Shops.BLL.Mapping
{
    public static class MapperForShop
    {
        public static ShopDAL MapToDALShop(this ShopBLL shop)
            => MapperForDAL().Map<ShopBLL, ShopDAL>(shop);
        public static ShopBLL MapToBLLShop(this ShopDAL shop)
            => MapperForBLL().Map<ShopDAL, ShopBLL>(shop);       

        public static IEnumerable<ShopBLL> MapToEnumerableBLLShop(this IEnumerable<ShopDAL> shops) 
            => MapperForBLL().Map<IEnumerable<ShopDAL>, IEnumerable<ShopBLL>>(shops);
        public static IEnumerable<ShopDAL> MapToEnumerableDALShop(this IEnumerable<ShopBLL> shops)
            => MapperForDAL().Map<IEnumerable<ShopBLL>, IEnumerable<ShopDAL>>(shops);
        public static IEnumerable<ProductDAL> MapToEnumerableDALProduct(this IEnumerable<ProductBLL> products) 
            => MapperForDAL().Map<IEnumerable<ProductBLL>, IEnumerable<ProductDAL>>(products);
        public static IEnumerable<ProductBLL> MapToEnumerableBLLProduct(this IEnumerable<ProductDAL> products) 
            => MapperForBLL().Map<IEnumerable<ProductDAL>, IEnumerable<ProductBLL>>(products);
        public static ProductBLL MapToBLLProduct(this ProductDAL product) 
            => MapperForBLL().Map<ProductDAL, ProductBLL>(product);
        public static ProductDAL MapToDALProduct(this ProductBLL product)
            => MapperForDAL().Map<ProductBLL, ProductDAL>(product);
        
        private static Mapper MapperForBLL()
        {
            var mapper = new MapperConfiguration(cfg => {

                cfg.CreateMap<ShopDAL, ShopBLL>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(c => c.Id))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(c => c.Name))
                    .ForMember(dest => dest.OperatingMode, opt => opt.MapFrom(c => c.OperatingMode))
                    .ForMember(dest => dest.Products, opt => opt.MapFrom(c => c.Products));

                cfg.CreateMap<ProductDAL, ProductBLL>()
                   .ForMember(d => d.Id, d => d.MapFrom(s => s.Id))
                   .ForMember(d => d.Name, d => d.MapFrom(s => s.Name))
                   .ForMember(d => d.Description, d => d.MapFrom(s => s.Description))
                   .ForMember(d => d.Shop, d => d.MapFrom(s => s.Shop))
                   .ForMember(d => d.ShopId, d => d.MapFrom(s => s.ShopId));
            });

            return new Mapper(mapper);
        }

        private static Mapper MapperForDAL()
        {
            var mapper = new MapperConfiguration(cfg => {

                cfg.CreateMap<ShopBLL, ShopDAL>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(c => c.Id))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(c => c.Name))
                    .ForMember(dest => dest.OperatingMode, opt => opt.MapFrom(c => c.OperatingMode))
                    .ForMember(dest => dest.Products, opt => opt.MapFrom(c => c.Products));

                cfg.CreateMap<ProductBLL, ProductDAL>()
                   .ForMember(d => d.Id, d => d.MapFrom(s => s.Id))
                   .ForMember(d => d.Name, d => d.MapFrom(s => s.Name))
                   .ForMember(d => d.Description, d => d.MapFrom(s => s.Description))
                   .ForMember(d => d.Shop, d => d.MapFrom(s => s.Shop))
                   .ForMember(d => d.ShopId, d => d.MapFrom(s => s.ShopId));

            });

            return new Mapper(mapper);
        }
    }
}
