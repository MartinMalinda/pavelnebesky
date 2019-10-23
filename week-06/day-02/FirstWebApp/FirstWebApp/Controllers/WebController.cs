using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstWebApp.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        public static int webCounter;

        [HttpGet("greeting")]
        public IActionResult Greeting(string name)
        {

            webCounter++;
            var greeting = new Greeting()
            {
                Id = webCounter,
                Content = name + "! This site was loaded " + webCounter + " times since last server start."
            };

            return View(greeting);
        }
    }
}
