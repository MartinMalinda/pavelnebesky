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
    public class SayHelloController : Controller
    {
        // GET: /<controller>/

        [HttpGet("sayhello")]
        public IActionResult SayHello()
        {
            var sayHello = new SayHello();
            

            return View(sayHello);
        }
    }
}
