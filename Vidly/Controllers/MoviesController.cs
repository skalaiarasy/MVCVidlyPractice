using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Movies()
        {
            
            List<Movie> movies = new List<Movie>
            {
                new Movie { Name = "Movie 1"},
                new Movie { Name = "Movie 2"}

            };

            RandomMovieViewModel randomMovieViewModel = new RandomMovieViewModel()
            {
                Movies = movies
                //Customer = customers
            };
            return View(randomMovieViewModel);
        }
    }
}