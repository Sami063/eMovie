using eMovie.Data;
using eMovie.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMovie.Controllers
{
    public class CinemaController : Controller
    {
        private readonly MovieDbContext _db;
        
        public CinemaController(MovieDbContext movieDbContext)
        {
            _db = movieDbContext;
        }
        // -------------------- List of Cinemas & Search action----------------------------

        public IActionResult Index(string searchCinema = "")
        {
            // var cinemas = _db.Cinemas.ToList();
            List<Cinema> GetCinemas = new List<Cinema>();
            
            if (searchCinema != "" && searchCinema != null)
            {
                GetCinemas = _db.Cinemas.Where(c => c.Name.Contains(searchCinema)).ToList();

            } else
            {
                GetCinemas = _db.Cinemas.ToList();
            }
            return View(GetCinemas);
        }

        // -------------------- Create ------------------------- 
        [HttpGet]
        public ActionResult Create()
        {
            Cinema cinema = new Cinema();
            return View(cinema);
        }

        [HttpPost]
        public ActionResult Create(Cinema cinema)
        {
            if(ModelState.IsValid)
            {
                _db.Cinemas.AddAsync(cinema);
                _db.SaveChangesAsync(); 
                return RedirectToAction("Index");
            } else
            {
                return View();
            }
        }

        // -------------------- Delete --------------------------
        public ActionResult Delete(int id)
        {
            var CinemaFromDb = _db.Cinemas.Find(id);
            if(CinemaFromDb == null)
            {
                return NotFound();
            }

            _db.Cinemas.Remove(CinemaFromDb);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Cinema()
        {
            var cinemas = _db.Cinemas.ToList();

            return View(cinemas);
        }
        // -------------------- Edit ----------------------------
    }
}
