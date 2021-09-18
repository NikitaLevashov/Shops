using AutoMapper;
using Shops.BLL.ModelsBLL;
using Shops.BLL.NewFolder;
using Shops.Models;
using System.Collections.Generic;

namespace Shops.Mapping
{
    public static class MapperForShop
    {
        public static Shop MapToUIShop(this ShopBLL shop)
           => MapperForUI().Map<ShopBLL, Shop>(shop);
        public static ShopBLL MapToBLLShop(this Shop shop)
            => MapperForBLL().Map<Shop, ShopBLL>(shop);

        public static IEnumerable<ShopBLL> MapToEnumerableBLLShop(this IEnumerable<Shop> shops)
            => MapperForBLL().Map<IEnumerable<Shop>, IEnumerable<ShopBLL>>(shops);
        public static IEnumerable<Shop> MapToEnumerableUIShop(this IEnumerable<ShopBLL> shops)
            => MapperForUI().Map<IEnumerable<ShopBLL>, IEnumerable<Shop>>(shops);
        public static IEnumerable<Product> MapToEnumerableUIProduct(this IEnumerable<ProductBLL> products)
            => MapperForUI().Map<IEnumerable<ProductBLL>, IEnumerable<Product>>(products);
        public static IEnumerable<ProductBLL> MapToEnumerableBLLProduct(this IEnumerable<Product> products)
            => MapperForBLL().Map<IEnumerable<Product>, IEnumerable<ProductBLL>>(products);
        public static ProductBLL MapToProduct(this Product product)
            => MapperForBLL().Map<Product, ProductBLL>(product);
        public static Product MapToUIProduct(this ProductBLL product)
            => MapperForUI().Map<ProductBLL, Product>(product);

        private static Mapper MapperForBLL()
        {
            var mapper = new MapperConfiguration(cfg => {

                cfg.CreateMap<Shop, ShopBLL>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(c => c.Id))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(c => c.Name))
                    .ForMember(dest => dest.OperatingMode, opt => opt.MapFrom(c => c.OperatingMode))
                    .ForMember(dest => dest.Products, opt => opt.MapFrom(c => c.Products));

                cfg.CreateMap<Product, ProductBLL>()
                   .ForMember(d => d.Id, d => d.MapFrom(s => s.Id))
                   .ForMember(d => d.Name, d => d.MapFrom(s => s.Name))
                   .ForMember(d => d.Description, d => d.MapFrom(s => s.Description))
                   .ForMember(d => d.Shop, d => d.MapFrom(s => s.Shop))
                   .ForMember(d => d.ShopId, d => d.MapFrom(s => s.ShopId));

            });

            return new Mapper(mapper);
        }

        private static Mapper MapperForUI()
        {
            var mapper = new MapperConfiguration(cfg => {

                cfg.CreateMap<ShopBLL, Shop>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(c => c.Id))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(c => c.Name))
                    .ForMember(dest => dest.OperatingMode, opt => opt.MapFrom(c => c.OperatingMode))
                    .ForMember(dest => dest.Products, opt => opt.MapFrom(c => c.Products));

                cfg.CreateMap<ProductBLL, Product>()
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
