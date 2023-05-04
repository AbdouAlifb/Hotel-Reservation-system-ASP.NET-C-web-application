using AuthMvc.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AuthMvc.Controllers
{
    public class RestaurationController : Controller
{
        private readonly ApplicationDbContext _context;

        public RestaurationController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: RegistreController

        public ActionResult Index()
        {
            var reservations = _context.Restaurants.ToList();
            return View(reservations);
        }

        public ActionResult Breakfast()
        {
            var reservations = _context.Restaurants.ToList();
            return View("Breakfast", reservations );
        }

        public ActionResult Lunch()
        {
            var reservations = _context.Restaurants.ToList();
            return View("Lunch", reservations);
        }

        public ActionResult Dinner()
        {
            var reservations = _context.Restaurants.ToList();
            return View("Dinner", reservations);
        }


        // GET: RestaurationController/Details/5
        public ActionResult Details(int id)
    {
        return View();
    }

    // GET: RestaurationController/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: RestaurationController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: RestaurationController/Edit/5
    public ActionResult Edit(int id)
    {
        return View();
    }

    // POST: RestaurationController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: RestaurationController/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: RestaurationController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }
}
}
