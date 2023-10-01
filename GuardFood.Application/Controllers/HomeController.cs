using Microsoft.AspNetCore.Mvc;

namespace GuardFood.Application.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
