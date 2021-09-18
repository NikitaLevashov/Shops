using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shops.BLL.Interfaces;
using Shops.BLL.SessionService;
using Shops.Mapping;
using Shops.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Shops.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IShopService _service;

        public HomeController(ILogger<HomeController> logger, IShopService service)
        {
            _service = service ?? throw new ArgumentNullException();
            _logger = logger ?? throw new ArgumentNullException();
        }

        public IActionResult Index()
        {
            var shops = _service.GetAll().MapToEnumerableUIShop();

            if(shops != null)
            {
                _logger.LogInformation("Getting all shops from the users table");
                return View(shops);
            }

            _logger.LogWarning($"GetAll() NOT FOUND");
            return NotFound();        
        }

        public IActionResult ShowProducts(int id)
        {
            var shop = _service.Get(id).MapToUIShop();

            if (shop != null)
            {
                HttpContext.Session.Set("Id", shop.Id);
                _logger.LogInformation("Successfully received the store.");
                return View(shop);
            }

            _logger.LogWarning($"Error NOT FOUND");
            return NotFound();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
