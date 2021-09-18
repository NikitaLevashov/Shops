using Shops.DAL.ModelsDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.DAL.EFCore
{
    public class SeedData
    {
        public static void SeedDatabase(ShopContext context)
        {
            if (!context.Products.Any() && !context.Shops.Any())
            {
                ShopDAL shop1 = new ShopDAL { Name = "SportShop", Adress = "100, Lenina avenue, Minsk", OperatingMode = "10:00 - 20:00" };
                ShopDAL shop2 = new ShopDAL { Name = "ProductShop", Adress = "20, Esenina avenue, Minsk", OperatingMode = "9:00 - 23:00" };
                ShopDAL shop3 = new ShopDAL { Name = "ElectronicShop", Adress = "34, Pushkina avenue, Minsk", OperatingMode = "10:00 - 22:00" };

                context.Shops.AddRange(shop1, shop2, shop3);

                ProductDAL product1 = new ProductDAL { Name = "Balls", Description = "A solid or hollow ball of elastic material that bounces when falling from a solid surface.", Shop = shop1 };
                ProductDAL product2 = new ProductDAL { Name = "Skates", Description = "Narrow steel runners to attach to ice skating shoes.", Shop = shop1};
                ProductDAL product3 = new ProductDAL { Name = "Hockey sticks", Description = "Curve, with a curved end, a stick, e.g. for playing hockey.", Shop = shop1};

                ProductDAL product4 = new ProductDAL { Name = "Сanned fishes", Description = "Fish products, pre-processed, sealed in an airtight container and sterilized.", Shop = shop2 };
                ProductDAL product5 = new ProductDAL { Name = "Pasta", Description = "Pasta in the form of tubes of different diameters and lengths", Shop = shop2 };
                ProductDAL product6 = new ProductDAL { Name = "Hockey sticks", Description = "Genus of annual and perennial herbaceous plants of the Cereals family.", Shop = shop2 };

                ProductDAL product7 = new ProductDAL { Name = "Computers", Description = "A device or system capable of performing a given, well-defined, variable sequence of operations.", Shop = shop3 };
                ProductDAL product8 = new ProductDAL { Name = "Mobile phones", Description = "Portable communication device primarily intended for voice communication.", Shop = shop3 };
                ProductDAL product9 = new ProductDAL { Name = "TV", Description = "A receiver of television image and sound signals, displaying them on the screen and using speakers.", Shop = shop3 };

                context.Products.AddRange(product1, product2, product3, product4, product5, product6, product7, product8, product9);

                context.SaveChanges();
            }
        }
    }
}
