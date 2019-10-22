using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstWebApp.Models
{
    public class Greeting
    {

        public long Id { get; set; }
        public string Content { get; set; }
        public int Counter { get; set; }
        public static int counter;

        public Greeting (int id, string content)
        {
            Id = id;
            Content = content;
            Counter = counter;
        }

        public Greeting()
        {
            
        }


        // GET: /<controller>/
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
