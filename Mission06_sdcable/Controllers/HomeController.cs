using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission06_sdcable.Models;

namespace Mission06_sdcable.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext _movieContext { get; set; }
        //Constructor

        public HomeController(ILogger<HomeController> logger, MovieContext data) //Bring in the _movieContext.
        {
            _logger = logger;
            _movieContext = data;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            ViewBag.Category = _movieContext.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(MovieModel ar) //HTTP post to save data when a post is done.
        {
            if (ModelState.IsValid)
            {
                _movieContext.Add(ar);
                _movieContext.SaveChanges();
                return View("Index");
            }
            else //Stay in view if not a valid modelstate.
            {
                ViewBag.Category = _movieContext.Categories.ToList();
                return View();
            }
            
        }



        [HttpGet]
        public IActionResult ViewMovies() 
        {
            ViewBag.Category = _movieContext.Categories.ToList();
            var x = _movieContext.responses
                .ToList();

            return View(x);
        }

        [HttpGet]
        public IActionResult Delete(int movieid) //Return a "Are you sure" screen with the users info
        {
            //Retrieving movideid in the paramters of the delete button and finding where in the contextvariable responses that equals the correct movieid
            var SingleMovie = _movieContext.responses.Single(x => x.MovieId == movieid);  

            return View(SingleMovie);
        }

        [HttpPost]
        public IActionResult Delete(MovieModel ar) //Delete info if yes
        {
            //The argument passed is the id of the model that you watn to delete.
            _movieContext.responses.Remove(ar);
            _movieContext.SaveChanges();
            return RedirectToAction("ViewMovies");
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Category = _movieContext.Categories.ToList();
            var SingleMovie = _movieContext.responses.Single(x => x.MovieId == movieid);

            return View("AddMovie", SingleMovie);
        }

        [HttpPost]
        public IActionResult Edit(MovieModel ar) //Update information in database for the movie.
        {
            _movieContext.Update(ar);
            _movieContext.SaveChanges();

            return RedirectToAction("ViewMovies");
        }







        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
