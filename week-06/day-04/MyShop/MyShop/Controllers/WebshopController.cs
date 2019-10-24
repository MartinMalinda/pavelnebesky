using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyShop.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyShop.Controllers
{
    [Route("")]
    public class WebshopController : Controller
    {

        List<ShopItem> shopItems = new List<ShopItem>() {
        new ShopItem("Running shoes", "Nike running shoes for everyday sport", 1000, 5),
        new ShopItem("Printer", "Some HP printer that prints pages", 3000, 2),
        new ShopItem("Coca cola", "Standard 0.5l coke", 25, 0),
        new ShopItem("Wokin", "Chicken with fried rice and WOKIN sauce", 119, 100),
        new ShopItem("T-skirt", "blue t-skirt with a rider on a bike", 300, 1),
        new ShopItem("Glass", "Standard lemonade glass", 80, 25)};


        // GET: /<controller>/
        [Route("")]
        public IActionResult Index(string search)
        {
            if (search == null)
            {
                ViewBag.Items = shopItems;
            }
            else
            {
                var filteredShopItems = shopItems.Where(s => (s.Name.ToUpper().Contains(search.ToUpper()) || s.Description.ToUpper().Contains(search.ToUpper()))).ToList();
                ViewBag.Items = filteredShopItems;
            }

            //ViewData["shopItems"] = shopItems;
            return View();
        }
        // GET: /<controller>/

        [Route("onlyAvailable")]
        public IActionResult OnlyAvailable()
        {
            var filteredShopItems = shopItems.Where(s => s.Quantity > 0).ToList();
            ViewBag.Items = filteredShopItems;
            return View("index");
        }

        [Route("cheapestFirst")]
        public IActionResult CheapestFirst()
        {
            var filteredShopItems = shopItems.OrderBy(s => s.Price).ToList();
            ViewBag.Items = filteredShopItems;
            return View("index");
        }

        [Route("containsNike")]
        public IActionResult ContainsNike()
        {
            var filteredShopItems = shopItems.Where(s => (s.Name.ToUpper().Contains("NIKE") || s.Description.ToUpper().Contains("NIKE"))).ToList();
            ViewBag.Items = filteredShopItems;

            return View("index");
        }

        [Route("mostExpensiveAvailable")]
        public IActionResult MostExpensive()
        {
            var filteredShopItem = shopItems.OrderByDescending(s => s.Price).First();
            List<ShopItem> filteredShopItems = new List<ShopItem>();
            filteredShopItems.Add(filteredShopItem);
            ViewBag.Items = filteredShopItems;
            return View("index");
        }

        [Route("averageStock")]
        public IActionResult AverageStock()
        {
            var filteredShopItem = shopItems.Average(s => s.Quantity);
            ViewBag.Average = filteredShopItem;
            return View();
        }

    }
}
