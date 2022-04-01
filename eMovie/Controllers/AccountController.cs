using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eMovie.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {
        /*
        [Route("")]
        [Route("index")]
        [Route("~/")] */
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("login")]
        public ActionResult LogIn(string username, string password)
        {
            if(username != null && password != null && username == "sam" && password == "password")
            {
                HttpContext.Session.SetString("username", username);
                return View("Success");
            }
            else
            {
                ViewBag.erorr = "Re";
                return View("index");
            }
        }
    }
}
