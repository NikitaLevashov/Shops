using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shops.Models
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string OperatingMode { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
