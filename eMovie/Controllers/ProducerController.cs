using eMovie.Data;
using eMovie.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace eMovie.Controllers
{
    public class ProducerController : Controller
    {
        private readonly MovieDbContext _db;

        public ProducerController(MovieDbContext movieDbContext)
        {
            _db = movieDbContext;
        }
        public IActionResult Index()
        {
            var GetAllProducers = _db.Producers.ToList();
            return View(GetAllProducers);
        }

        // Create new Producer

        [HttpGet]
        public ActionResult Create()
        {
            Producer producer = new Producer();
            return View(producer);
        }

        [HttpPost]
        public ActionResult Create(Producer producer)
        {
            if(ModelState.IsValid)
            {
                _db.Producers.AddAsync(producer);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
