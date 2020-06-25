using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMVC5.Models;
using VidlyMVC5.ViewModels;

namespace VidlyMVC5.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer() { Name = "cust1"},
                new Customer() { Name = "cust2"}
            };

            var viewModel = new MovieCustomersViewModel() { Movie = movie, Customers = customers };
            return View(viewModel);
        }

        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<VidlyMVC5.Models.Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie{ Id = 1, Name = "Shrek1!"},
                new Movie{ Id = 2, Name = "Gone with the Wind!"}
            };
        }

        
    }
}