using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shops.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(15)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
    }
}
