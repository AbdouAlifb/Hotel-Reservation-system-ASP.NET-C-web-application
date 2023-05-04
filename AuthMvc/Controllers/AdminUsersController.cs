using AuthMvc.Data;
using AuthMvc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Xml.Schema;

namespace Hotel_IRISI.Controllers
{
    public class AdminUsersController : Controller
    {
        public readonly ApplicationDbContext _context;
        private UserManager<IdentityUser> _userManager;

        public AdminUsersController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        // GET: RegistreController
        public ActionResult Index()
        {
            var clients = _userManager.Users.ToList();
            return View(clients);
        }



        // GET: RegistreController/Details/5
        public ActionResult Details(string id)
        {
            var clients = _context.Users.Find(id);
            return View(clients);
        }

        // GET: RegistreController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegistreController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserAccount user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RegistreController/Edit/5
        public ActionResult Edit(string id)
        {
            var client = _context.Users.Find(id);
            return View(client);
        }

        // POST: RegistreController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserAccount user)
        {
            try
            {
                _context.Users.Update(user);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RegistreController/Delete/5
        public ActionResult Delete(string id)
        {
            var user = _context.Users.Find(id);
            return View(user);
        }

        // POST: RegistreController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(UserAccount user)
        {
            try
            {
                _context.Users.Remove(user);
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