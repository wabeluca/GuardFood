using Microsoft.AspNetCore.Mvc;

namespace GuardFood.Api.Controllers
{
    public class PedidoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
