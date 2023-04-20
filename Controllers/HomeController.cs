using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mission06_jrencher.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mission06_jrencher.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieResponseContext enteredContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieResponseContext mrc)
        {
            _logger = logger;
            enteredContext = mrc;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcast()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(MovieResponse mr)
        {
            enteredContext.Add(mr);
            enteredContext.SaveChanges();
            return View("Confirmation", mr);
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
