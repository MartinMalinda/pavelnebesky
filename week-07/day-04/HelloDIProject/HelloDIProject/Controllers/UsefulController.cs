using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloDIProject;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloDIProject.Controllers
{
    [Route("useful")]
    public class UsefulController : Controller
    {

        UtilityService utilityService;

        public UsefulController (UtilityService utilityService)
        {
            this.utilityService = utilityService;
        }

        [Route("")]
        public IActionResult Useful()
        {
            return View();
        }

        // GET: /<controller>/
        [Route("colored")]
        public IActionResult Colored()
        {
            return View(utilityService);
        }

        [Route("email")]
        public IActionResult Email(String email, UtilityService utilityService)
        {
            
            return View("email", utilityService.ValidateEmail(email));

        }

        [Route("encoder")]
        public IActionResult Encoder(string text, int number, UtilityService utilityService)
        {

            return View("encoder", utilityService.Caesar(text,number));

        }

        [Route("decoder")]
        public IActionResult Decoder(string text, int number, UtilityService utilityService)
        {

            return View("decoder", utilityService.Caesar(text, -number));

        }




    }
}
