using AuthMvc.Data;
using AuthMvc.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace AuthMvc.Controllers
{
	public class BookController : Controller
	{
		private readonly ApplicationDbContext _context;

		public BookController(ApplicationDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			return View();
		}
		[AllowAnonymous]
		public ActionResult Book(int id)
		{
			var reservation = new Reservation
			{
				IdChambre = id,
				UserName = User.Identity.Name


            };
            
            return View(reservation);
        }
     

        // POST: RegistreController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Book(Reservation reservation)
        {
            try
            {
                _context.Reservations.Add(reservation);
                _context.SaveChanges();
                return Redirect("/Home/Index");
            }
            catch
            {
                return View();
            }
        }
	}
}
