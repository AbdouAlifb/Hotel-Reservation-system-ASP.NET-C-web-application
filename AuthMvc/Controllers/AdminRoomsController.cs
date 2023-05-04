using AuthMvc.Data;
using AuthMvc.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Linq;
using System.Xml.Schema;

namespace Hotel_IRISI.Controllers
{
    public class AdminRoomsController : Controller
    {
        private readonly ApplicationDbContext _context;
        [System.Obsolete]
        private readonly IHostingEnvironment hosting;

        [System.Obsolete]
        public AdminRoomsController(ApplicationDbContext context, IHostingEnvironment hosting)
        {
            _context = context;
            this.hosting = hosting;
        }
        // GET: RegistreController

        public ActionResult Index()
        {
            var room = _context.Rooms.ToList();
            return View(room);
        }

        // GET: RegistreController/Details/5
        public ActionResult Details(int id)
        {
            var room = _context.Rooms.Find(id);
            return View(room);
        }

        // GET: RegistreController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegistreController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [System.Obsolete]
        public ActionResult Create(Chambre room)
        {
            try
            {
                string fileName = string.Empty;
                if (room.File != null)
                {
                    string images = Path.Combine(hosting.WebRootPath, "images");
                    fileName = room.File.FileName;
                    string fullPath = Path.Combine(images, fileName);
                    room.File.CopyTo(new FileStream(fullPath, FileMode.Create));

                }
                _context.Rooms.Add(room);
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
            var room = _context.Rooms.Find(id);
            return View(room);
        }

        // POST: RegistreController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [System.Obsolete]
        public ActionResult Edit(Chambre room)
        {
            try
            {
                string fileName = string.Empty;
                if (room.File != null)
                {
                    string images = Path.Combine(hosting.WebRootPath, "images");
                    fileName = room.File.FileName;
                    string fullPath = Path.Combine(images, fileName);
                    room.File.CopyTo(new FileStream(fullPath, FileMode.Create));

                }
                _context.Rooms.Update(room);
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
            var room = _context.Rooms.Find(id);
            return View(room);
        }

        // POST: RegistreController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Chambre room)
        {
            try
            {
                _context.Rooms.Remove(room);
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