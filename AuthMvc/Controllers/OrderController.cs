using AuthMvc.Data;
using AuthMvc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AuthMvc.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        private readonly ApplicationDbContext _context;
        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: AdminRestaurantController1
        public ActionResult Index()
        {
            var restaurant = _context.Orders.ToList();
            return View(restaurant);

        }

        // GET: AdminRestaurantController1/Details/5
        public ActionResult Details(int id)
        {
            var restaurant = _context.Orders.Find(id);
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
        public ActionResult Create(Order order)
        {
            try
            {
                _context.Orders.Add(order);
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
            var restaurant = _context.Orders.Find(id);
            return View(restaurant);
        }

        // POST: AdminRestaurantController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Order order)
        {
            try
            {
                _context.Orders.Update(order);
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
            var restaurant = _context.Orders.Find(id);
            return View(restaurant);
        }

        // POST: AdminRestaurantController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Order order)
        {
            try
            {
                _context.Orders.Remove(order);
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
