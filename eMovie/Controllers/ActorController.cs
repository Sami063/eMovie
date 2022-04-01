using eMovie.Data;
using eMovie.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace eMovie.Controllers
{
    public class ActorController : Controller
    {
        private readonly MovieDbContext db;

        public ActorController(MovieDbContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            var GetAllActors = db.Actors.ToList();
            return View(GetAllActors);
        }

        [HttpGet]
        public ActionResult Create()
        {
            Actor actor = new Actor();
            return View(actor);
        }

        [HttpPost]
        public ActionResult Create(Actor actor)
        {
            if(ModelState.IsValid)
            {
                db.Actors.AddAsync(actor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int? id)
        {
            var ActorFromDb = db.Actors.Find(id);
            if(ActorFromDb == null)
            {
                return NotFound();
            }
            db.Actors.Remove(ActorFromDb);
            db.SaveChanges();
            return View("Index");
        }
    }
}
