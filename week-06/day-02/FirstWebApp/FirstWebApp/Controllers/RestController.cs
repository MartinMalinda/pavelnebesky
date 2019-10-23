using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstWebApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstWebApp.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {
        public static int restCounter;
        // GET: /<controller>/
        [Route("greeting")]
        [HttpGet]
        public Greeting Greet(string name)
        {
            restCounter++;

            Greeting greeting = new Greeting(restCounter ,"Hello, "+ name + "!");

            return greeting;
        }
    }
}
