using AuthMvc.Data;
using AuthMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;

namespace AuthMvc.Controllers
{
    public class AdminReservationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminReservationsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: RegistreController

        public ActionResult Index()
        {
            var reservations = _context.Reservations.ToList();
            return View(reservations);
        }
        public IActionResult GetStat()
        {
            ViewBag.Names = JsonConvert.SerializeObject(_context.Rooms.Select(r => r.Name).Distinct().OrderBy(r => r).ToList());
            var query = from r in _context.Rooms
                        join n in _context.Reservations on r.IdChambre equals n.IdChambre
                        group n by r.Name into g
                        orderby g.Key
                        select g.Count();
            var counts = query.ToList();

            ViewBag.Reservations = JsonConvert.SerializeObject(counts);
            return View();
        }

        // GET: RegistreController/Details/5
        public ActionResult Details(int id)
        {
            var reservations = _context.Reservations.Find(id);
            return View(reservations);
        }

        // GET: RegistreController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegistreController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Reservation reservation)
        {
            try
            {
                _context.Reservations.Add(reservation);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RegistreController/Edit/5
        public ActionResult Edit(int id)
        {
            var reservation = _context.Reservations.Find(id);
            return View(reservation);
        }

        // POST: RegistreController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Reservation reservation)
        {
            try
            {
                _context.Reservations.Update(reservation);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RegistreController/Delete/5
        public ActionResult Delete(int id)
        {
            var reservations = _context.Reservations.Find(id);
            return View(reservations);
        }

        // POST: RegistreController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Reservation reservation)
        {
            try
            {
                _context.Reservations.Remove(reservation);
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
