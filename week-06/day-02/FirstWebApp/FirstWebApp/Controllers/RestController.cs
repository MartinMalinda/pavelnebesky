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

        

        // GET: /<controller>/
        [Route("greeting")]
        [HttpGet]
        public Greeting Greet(string name)
        {
            Greeting.counter++;

            Greeting greeting = new Greeting(Greeting.counter,"Hello, "+ name + "!");

            return greeting;
        }
    }
}
