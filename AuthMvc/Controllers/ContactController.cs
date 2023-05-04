using Microsoft.AspNetCore.Mvc;

namespace AuthMvc.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
