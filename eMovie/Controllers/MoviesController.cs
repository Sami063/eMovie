using eMovie.Data;
using eMovie.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMovie.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MovieDbContext db;

        public MoviesController(MovieDbContext context)
        {
            db = context;
        }

        // --------------- Movies view -------------------
        public ActionResult Index(string searchMovie = "")
        {
            List<Movie> GetMovie = new List<Movie>();

            if (searchMovie != "" && searchMovie != null)
            {
                //GetMovie = db.Movies.Where(m => m.Name.Contains(searchMovie)).ToList();
                GetMovie = db.Movies.Include(c => c.Cinema).Where(m => m.Name.Contains(searchMovie)).ToList();
            } else 
            {
                GetMovie =  db.Movies.Include(c => c.Cinema).ToList();
            }
            return View("Index", GetMovie);
        }

        // --------------- Filters Fiction Movies ---------
        public ActionResult Fiction()
        { 
            List<Movie> ActionMovie = new List<Movie>();
            ActionMovie = db.Movies.Include(c => c.Cinema).Where(m => m.MovieCategory == MovieCategory.Fiction).ToList();
            return View("Index", ActionMovie);
        }

        // --------------- Filters Comedy Movies ---------
        public ActionResult Comedy()
        {
            List<Movie> ActionMovie = new List<Movie>();
            ActionMovie = db.Movies.Include(c => c.Cinema).Where(m => m.MovieCategory == MovieCategory.Comedy).ToList();
            return View("Index", ActionMovie);
        }

        // --------------- Filters Documentary Movies ---------
        public ActionResult Documentary()
        {
            List<Movie> ActionMovie = new List<Movie>();
            ActionMovie = db.Movies.Include(c => c.Cinema).Where(m => m.MovieCategory == MovieCategory.Documentary).ToList();
            return View("Index", ActionMovie); 
        }

        // --------------- Filters Action Movies ---------
        public ActionResult Action() 
        {
            List<Movie> ActionMovie = new List<Movie>();
            ActionMovie = db.Movies.Include(c => c.Cinema).Where(m => m.MovieCategory == MovieCategory.Action).ToList();
            return View("Index", ActionMovie);
        }

        // --------------- Details view -------------------
        public ActionResult Detail(int id)
        {
            // The result of the expression is always the same since a value of this type is never equal to 'null'
            // Get Actors from data base in the Movie detail page

            var MovieDetail = db.Movies.Where(x => x.Id == id).FirstOrDefault();
            if (MovieDetail == null)
            {
                return NotFound();
            }
            return View(MovieDetail);
        }

        // -------- Only visible to admin, can edit and delete -----------------
        public ActionResult AdminMoviePage(string searchMovie)
        {
            List<Movie> GetMovie = new List<Movie>();

            if (searchMovie != "" && searchMovie != null)
            {
                GetMovie = db.Movies.Where(m => m.Name.Contains(searchMovie)).ToList();
            }
            else
            {
                GetMovie = db.Movies.ToList();
            }
            return View("AdminMoviePage", GetMovie);
        }

        public ActionResult Edit()
        {
            var AllMovies = db.Movies.ToList();
            return View(AllMovies); 
        }
        // Delete Movies
        public ActionResult Delete(int? id)
        {
            var MovieFromDb = db.Movies.Where(x => x.Id == id).FirstOrDefault();
            if(MovieFromDb == null) 
                return NotFound();
            db.Movies.Remove(MovieFromDb);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // -----------------Create movie ----------------------------
        [HttpGet]
        public ActionResult CreateMovie()
        {
            Movie movie = new Movie();
            return View(movie);
        }

        [HttpPost]
        public ActionResult CreateMovie(Movie movie)
        {
            if(ModelState.IsValid)
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return RedirectToAction("index");
            }
            return View(movie);
        }
    }
}
