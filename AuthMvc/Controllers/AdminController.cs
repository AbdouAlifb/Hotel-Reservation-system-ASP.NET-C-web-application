using Microsoft.AspNetCore.Mvc;

namespace AuthMvc.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}