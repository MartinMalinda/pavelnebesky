using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using foxClub.Models;
using foxClub.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace foxClub.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {

        FoxServices foxServices;

        public HomeController(FoxServices foxServices)
        {
            this.foxServices = foxServices;
        }

        // GET: /<controller>/
        //[Route("home")]
        public IActionResult Index(string name)
        {
            Fox selectedFox = foxServices.foxes.Find(f => f.Name == name);

            return View(selectedFox);
        }

        [Route("login")]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [Route("login")]
        [HttpPost]
        public IActionResult Login(string name)
        {
            foxServices.foxes.Add(new Fox(name));
            //Response.Redirect("/?name="+name);
            return RedirectToAction("Index", "Home", new { name = name }); //anonymous object
        }

    }
}
