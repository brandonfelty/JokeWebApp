using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JokesWebApp.Controllers
{
    public class JokeController : Controller
    {
        // GET: /<Jokes>/
        public IActionResult Index()
        {
            return View();
        }

        public string Welcome()
        {
            return "This is the joke page";
        }
    }
}

