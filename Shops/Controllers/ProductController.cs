using Microsoft.AspNetCore.Mvc;
using Shops.BLL.Interfaces;
using Shops.BLL.SessionService;
using Shops.Mapping;
using Shops.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shops.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService, IShopService shopService)
        {
            _productService = productService ?? throw new ArgumentNullException();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(int id)
        {
            var product = _productService.Get(id).MapToUIProduct();

            if (product != null)
                return View(product);

            return NotFound();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            if (id != 0)
            {
                _productService.Delete(id);

                return RedirectToAction("Index", "Home");
            }

            return NotFound();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            product.ShopId = HttpContext.Session.Get<int>("Id");
            _productService.Create(product.MapToProduct());

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var product = _productService.Get(id).MapToUIProduct();

            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            if (product != null)
            {
                _productService.Update(product.MapToProduct());

                return RedirectToAction("Index", "Home");
            }

            return BadRequest();
        }
    }
}
