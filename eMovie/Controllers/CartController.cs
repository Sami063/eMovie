using eMovie.Data;
using eMovie.Helper;
using eMovie.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eMovie.Controllers
{
    [Route("cart")]
    public class CartController : Controller
    {
        // To have access to the data from my database by using _db.find(id) - from "MovieDbContext"
        private readonly MovieDbContext _db;
        public CartController(MovieDbContext context)
        {
            _db = context;
        }

        [Route("index")]
        public ActionResult Index()
        {
            var cart = SesstionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;

            ViewBag.total = cart.Sum(item => item.Movie.Price * item.Quantity);

            return View();
        }

        // Buy Action - User can store items
        // into the cart by clicking the Buy btn


        [Route("buy/{id}")]
        public ActionResult Buy(int id)
        {
            Movie movie = new Movie();
            if (SesstionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item { Movie = _db.find(id), Quantity = 1 });
                SesstionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<Item> cart = SesstionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                int index = IsExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Item { Movie = _db.find(id), Quantity = 1 });
                }
                SesstionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("index");
        }

        // Remove one item from shopping cart, Including Quantity
        public ActionResult Remove(int id)
        {
            List<Item> cart = SesstionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)

                if (cart[i].Movie.Id.Equals(id))
                {
                    cart.Remove(cart[i]);
                }
            SesstionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);

            return RedirectToAction("index");
        }

         // ------------If Exists ------------------------------
        private int IsExist(int id)
        {
            List<Item> cart = SesstionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)

                if (cart[i].Movie.Id.Equals(id))
                {
                    return i;
                }
            return -1; // Any way it will return false 
        }

        // Removing all Items in the shopping cart
        /*
        [Route("removeall")]
        public ActionResult RemoveAll()
        {
            List<Item> cart = SesstionHelper.GetObjectFromJson<List<Item>> (HttpContext.Session, "cart");
            for(int i = 0; i < cart.Count; i--)
            {
                cart.Remove(cart[i]);
            }
            SesstionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);

            return View("Index");
        } */

        // ------------Increase Item By One --------------------
        [Route("increaseItem/{id}")]
        public ActionResult IncreaseItem(int id)
        {
            List<Item> cart = SesstionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");

            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Movie.Id.Equals(id))
                    cart[i].Quantity++;

            SesstionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);

            return RedirectToAction("index");
        }

        // ------------Decrease Item By One --------------------
        [Route("decreaseItem/{id}")]
        public ActionResult DecreaseItem(int id)
        {
            List<Item> cart = SesstionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");

            // If CartQuantity < 0, this will decrese the Quantity by one.
            int CartQuantity;
            for (CartQuantity = 0; CartQuantity < cart.Count; CartQuantity++)
                if (cart[CartQuantity].Movie.Id.Equals(id))
                    cart[CartQuantity].Quantity--;

            // If CartQuantity == 0, this will remove the item in the shopping cart.
            for (CartQuantity = 0; CartQuantity < cart.Count; CartQuantity++)
                if (cart[CartQuantity].Quantity == 0)
                    cart.Remove(cart[CartQuantity]);

            SesstionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);

            return RedirectToAction("index");
        } 
    }
}
