using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        private MovieResponseContext enteredContext { get; set; }

        public HomeController(MovieResponseContext mrc)
        {
            enteredContext = mrc;
        }

        //Returns Home Page
        public IActionResult Index()
        {
            return View();
        }

        //Returns Podcast View
        public IActionResult Podcast()
        {
            return View();
        }

        //Returns MovieForm View
        [HttpGet]
        public IActionResult MovieForm ()
        {
            ViewBag.Categories = enteredContext.Categories.ToList();
            return View();
        }

        //Passes entered data to the database and saves it. Returns the confirmation view.
        [HttpPost]
        public IActionResult MovieForm(MovieResponse mr)
        {
            enteredContext.Add(mr);
            enteredContext.SaveChanges();
            return View("Confirmation", mr);
        }

        [HttpGet]
        public IActionResult MoviesView()
        {
            //Sends responses to a list and passes the list to the view
            var movies = enteredContext.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();
            return View(movies);
        }
    }
}
