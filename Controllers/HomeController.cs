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
        public IActionResult MovieForm()
        {
            ViewBag.Categories = enteredContext.Categories.ToList();
            return View();
        }

        //Passes entered data to the database and saves it. Returns the confirmation view.
        [HttpPost]
        public IActionResult MovieForm(MovieResponse mr)
        {
            if (ModelState.IsValid)
            {
                enteredContext.Add(mr);
                enteredContext.SaveChanges();
                return View("Confirmation", mr);
            }
            else //If Invalid
            {
                ViewBag.Categories = enteredContext.Categories.ToList();
                return View(mr);
            }

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

        //Creates a way to edit entries
        [HttpGet]
        public IActionResult Edit(string title)
        {
            ViewBag.Categories = enteredContext.Categories.ToList();
            var category = enteredContext.Responses.Single(x => x.Title == title);
            return View("MovieForm", category);
        }

        //Submits and saves the changes
        [HttpPost]
        public IActionResult Edit(MovieResponse mr)
        {
            enteredContext.Update(mr);
            enteredContext.SaveChanges();
            return RedirectToAction("MoviesView");
        }

        //Gets data to be able to delete record
        [HttpGet]
        public IActionResult Delete(string title)
        {
            var category = enteredContext.Responses.Single(x => x.Title == title);
            return View(category);
        }

        //Deletes records
        [HttpPost]
        public IActionResult Delete(MovieResponse mr)
        {
            enteredContext.Responses.Remove(mr);
            enteredContext.SaveChanges();
            return RedirectToAction("MoviesView");
        }
    }
}
