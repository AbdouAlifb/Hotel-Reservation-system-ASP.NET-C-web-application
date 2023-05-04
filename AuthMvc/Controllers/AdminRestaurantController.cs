using AuthMvc.Data;
using AuthMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;


namespace AuthMvc.Controllers
{


        public class AdminRestaurantController : Controller
        {
            private readonly ApplicationDbContext _context;
            public AdminRestaurantController(ApplicationDbContext context)
            {
                _context = context;
            }
            // GET: AdminRestaurantController1
            public ActionResult Index()
            {
                var restaurant = _context.Restaurants.ToList();
                return View(restaurant);

            }

       

        // GET: AdminRestaurantController1/Details/5
        public ActionResult Details(int id)
            {
                var restaurant = _context.Restaurants.Find(id);
                return View();
            }

            // GET: AdminRestaurantController1/Create
            public ActionResult Create()
            {
                return View();
            }

            // POST: AdminRestaurantController1/Create
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Create(Restaurant restaurant)
            {
                try
                {
                    _context.Restaurants.Add(restaurant);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }

            // GET: AdminRestaurantController1/Edit/5
            public ActionResult Edit(int id)
            {
                var restaurant = _context.Restaurants.Find(id);
                return View(restaurant);
            }

            // POST: AdminRestaurantController1/Edit/5
            [HttpPost]
            [ValidateAntiForgeryToken]
        public ActionResult Edit(Restaurant restaurant)
          {
            try
            {
                _context.Restaurants.Update(restaurant);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

            // GET: AdminRestaurantController1/Delete/5
            public ActionResult Delete(int id)
            {
                var restaurant = _context.Restaurants.Find(id);
                return View(restaurant);
            }

            // POST: AdminRestaurantController1/Delete/5
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Delete(Restaurant restaurant)
            {
                try
                {
                    _context.Restaurants.Remove(restaurant);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
        }

    
}
